let flags = document.querySelectorAll("[data-flag]");
let textToTranslate = document.querySelectorAll("[data-translation]");
let translations = JSON.parse(document.currentScript.getAttribute('translation_text'));
let lang;

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

function UpdateLanguage(lang) {
    textToTranslate.forEach(el => {
        switch (lang) {
            case 'da':
                try {
                    el.innerText = `${translations[el.getAttribute("data-translation") - 1].Danish}`;
                } catch (e) {
                    el.innerText = `Dansk`;
                }
                break;
            case 'en':
                try {
                    el.innerText = `${translations[el.getAttribute("data-translation") - 1].English}`;
                } catch (e) {
                    el.innerText = `English`;
                }
                break;
            case 'hu':
                try {
                    el.innerText = `${translations[el.getAttribute("data-translation") - 1].Hungary}`;
                } catch (e) {
                    el.innerText = `Magyar`;
                }
                break;
            default:
                try {
                    el.innerText = `${translations[el.getAttribute("data-translation") - 1].English}`;
                } catch (e) {
                    el.innerText = `English`;
                }
                break;
        }
    });
}

function SetLanguage(el) {
    UpdateLanguage(el.getAttribute("data-flag"));

    flags.forEach(flag => {
        flag.classList.remove("selected");
    });

    el.classList.add("selected");
}

flags.forEach(flag => {
    if (lang == flag.getAttribute("data-flag")) {
        flag.classList.add("selected");
    }

    //flag.addEventListener("click", (e) => {
    //    console.log(`Clicked on ${e.target}`);
    //});
});