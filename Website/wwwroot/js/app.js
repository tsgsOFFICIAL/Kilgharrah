const flags = document.querySelectorAll("[data-flag]"); // An array of all Flags / Images
const textToTranslate = document.querySelectorAll("[data-translation]"); // An array of all HTML elements to translate
const translations = JSON.parse(document.currentScript.getAttribute('translation_text')); // The translation text as JSON
const planetObjects = JSON.parse(document.currentScript.getAttribute('planets_text')); // All planets & their information as JSON
const planets = document.querySelectorAll("[data-click]"); // An array of all Planets
const modal = document.getElementById("information-modal"); // A modal, for displaying information about the planets
const modal_close_btn = document.getElementById("information-modal-close-btn"); // The closing button 'x' for the modal
let ws;
try {
    ws = new WebSocket("ws://10.108.149.14:8008"); // A WebSocket instance
} catch (e) { }
let lang; // The language code

planetObjects.forEach(planetObj => {
    planetObj.Info_as_json = JSON.parse(planetObj.Info_as_json);
});

// Find the language from the browser default.
switch (navigator.language) {
    case 'da':
    case 'da-DK':
        lang = "da";
        break;
    case 'en':
    case 'en-US':
    case 'en-GB':
        lang = "en";
        break;
    case 'hu':
        lang = "hu";
        break;
    default:
        lang = "en";
        break;
}

// A function to update the HTML with a new language, in case it was changed
function UpdateLanguage() {
    textToTranslate.forEach(el => {
        switch (lang) {
            case 'da':
                try {
                    el.innerText = `${translations[el.getAttribute("data-translation") - 1].Da}`;
                } catch (e) {
                    el.innerText = `Dansk`;
                }
                break;
            case 'en':
                try {
                    el.innerText = `${translations[el.getAttribute("data-translation") - 1].En}`;
                } catch (e) {
                    el.innerText = `English`;
                }
                break;
            case 'hu':
                try {
                    el.innerText = `${translations[el.getAttribute("data-translation") - 1].Hu}`;
                } catch (e) {
                    el.innerText = `Magyar`;
                }
                break;
            default:
                try {
                    el.innerText = `${translations[el.getAttribute("data-translation") - 1].En}`;
                } catch (e) {
                    el.innerText = `English`;
                }
                break;
        }
    });
}

// A helper function to set the language, highlight the selected flag & update the HTML text
function SetLanguage(el) {
    lang = el.getAttribute("data-flag");
    UpdateLanguage();

    flags.forEach(flag => {
        flag.classList.remove("selected");
    });

    el.classList.add("selected");
}

// On load, run this to select the default language flag & highlight it
flags.forEach(flag => {
    if (lang == flag.getAttribute("data-flag")) {
        flag.classList.add("selected");
    }

    flag.addEventListener("click", () => {
        SetLanguage(flag);
    });
});

// Add an eventlistener of click to all planets
planets.forEach(planet => {
    /*
    let planetIndex = planet.getAttribute("data-index");
    let factIndex = 0;
    let maxIndex = planetObjects[planetIndex].Info_as_json.Statements.length - 1;
    */
    planet.addEventListener("click", () => {
        let planetIndex = planet.getAttribute("data-index");

        let index = 0;
        for (let i = 0; i < planetObjects.length; i++) {
            if (planetObjects[i].Id == planetIndex && planetObjects[i].Lang == lang) {
                index = i;
                i = planetObjects.length;
            }
        }
        planetIndex = index;

        let factIndex = 0;
        let maxIndex = planetObjects[planetIndex].Info_as_json.Statements.length - 1;

        document.querySelector("body").style.overflowY = "hidden"; // Disable scroll on the body
        modal.classList.add("open");

        // Update the modal content
        const modalHeader = modal.querySelector(".header h3");

        modalHeader.querySelector(".icon").src = planet.src;
        modalHeader.querySelector("span").innerText = planet.alt;

        const modalContent = modal.querySelector(".content>p.fact");
        const prevFact = modal.querySelector(".content .prev-btn");
        const nextFact = modal.querySelector(".content .next-btn");

        prevFact.addEventListener("click", () => {
            factIndex = factIndex > 0 ? factIndex - 1 : 0;
            modalContent.innerHTML = planetObjects[planetIndex].Info_as_json.Statements[factIndex];
        });

        nextFact.addEventListener("click", () => {
            factIndex = factIndex < maxIndex ? factIndex + 1 : maxIndex;
            modalContent.innerHTML = planetObjects[planetIndex].Info_as_json.Statements[factIndex];
        });

        modalContent.innerHTML = planetObjects[planetIndex].Info_as_json.Statements[factIndex]; // Set the fact to the first one


        // ws.send(planet.getAttribute("data-click")); // Send a WebSocket message to move an Arduino
    });
});

// Add closing action to the information modal
modal_close_btn.addEventListener("click", () => {
    modal.classList.add("closing");

    document.querySelector("body").style.overflowY = "auto"; // Enable scrolling on the body again

    modal.addEventListener("animationend", animationEnd);
});

// When the animation ends, remove the classes & eventlistener
function animationEnd() {
    modal.classList.remove("open");
    modal.classList.remove("closing");

    modal.removeEventListener("animationend", animationEnd);
}

// Run it on load
UpdateLanguage(lang);