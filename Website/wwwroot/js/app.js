const flags = document.querySelectorAll("[data-flag]"); // An array of all Flags / Images
const textToTranslate = document.querySelectorAll("[data-translation]"); // An array of all HTML elements to translate
const translations = JSON.parse(document.currentScript.getAttribute('translation_text')); // The translation text as JSON
const planetObjects = JSON.parse(document.currentScript.getAttribute('planets_text')); // All planets & their information as JSON
const planets = document.querySelectorAll("[data-click]"); // An array of all Planets
const ws = new WebSocket("ws://10.108.149.14:8008"); // A WebSocket instance
const modal = document.getElementById("information-modal"); // A modal, for displaying information about the planets
const modal_close_btn = document.getElementById("information-modal-close-btn"); // The closing button 'x' for the modal
let lang; // The language code

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
function UpdateLanguage(lang) {
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
    UpdateLanguage(el.getAttribute("data-flag"));

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
    planet.addEventListener("click", () => {
        document.querySelector("body").style.overflowY = "hidden"; // Disable scroll on the body
        modal.classList.add("open");

        // Update the modal content
        const modalHeader = modal.querySelector(".header h3");

        modalHeader.querySelector(".icon").src = planet.src;
        modalHeader.querySelector("span").innerText = planet.alt;

        const modalContent = modal.querySelector(".content");



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