// main.htm JavaScript source code

/* Loop through all dropdown buttons to toggle between hiding and showing its dropdown content. 
 * This allows the user to have multiple dropdowns without any conflict */
var dropdown = document.getElementsByClassName("dropdown-btn");

for (var i = 0; i < dropdown.length; i++) {
    dropdown[i].addEventListener("click", function () {
        this.classList.toggle("active");
        toggleDropdown(this);
    });
}

function toggleDropdown(elem) {
    var dropdownContent = elem.nextElementSibling;
    if (dropdownContent.style.display === "block") {
        dropdownContent.style.display = "none";
        elem.children["caret"].innerHTML = "&#8744;"; // Logical Or &or; Down arrow.
    } else {
        dropdownContent.style.display = "block";
        elem.children["caret"].innerHTML = "&#8743;"; // Logical And &and; Up arrow.
    }
}

/* Loop through all shared class "sidenav" href */
var hrefs = document.getElementsByClassName("sidenav");
var anchors;

//Looks links inside of a shared class "sidenav"
for (var i = 0; i < hrefs.length; i++) {
    anchors = hrefs[0].getElementsByTagName("a")
    for (var j = 0; j < anchors.length; j++) {
        anchors[j].addEventListener("click", function () {
            toggleDropdownContainers(this);
            setiFrameSource(this.hash.replace("#", ""));
            setActiveLink(this.hash);
        });
    }
}

function toggleDropdownContainers(elem) {
    if (elem.parentElement.classList.contains("dropdown-container")) {
        return;
    }
    for (var i = 0; i < dropdown.length; i++) {
        if (dropdown[i].children["caret"].innerHTML.charCodeAt(0) === 8743 // Logical And &and; Up arrow.
            && dropdown[i].hash != elem.hash) {
            toggleDropdown(dropdown[i]);
        }
    }
}

var hash = decodeURIComponent(window.location.hash).substring(1);
setiFrameSource(hash);
window.history.pushState({}, document.title, window.location.pathname + "#" + hash);
setActiveLink(window.location.hash);
queryDropdownContainer(window.location.hash.replace("#", "").toUpperCase(), true);

function setiFrameSource(src) {
    var ifrmPages = document.getElementById("iframePages");
    if (src != "")
        ifrmPages.setAttribute("src", src + ".htm");
    else {
        src = hash = ifrmPages.getAttribute("src").replace(".htm", "");
    }
}

function setActiveLink(src) {
    for (var i = 0; i < anchors.length; i++) {
        if (anchors[i].hash === src) {
            anchors[i].focus();
            if (!anchors[i].classList.contains("active")) {
                anchors[i].classList.add("active");
            }
        } else if (anchors[i].classList.contains("active")) {
            anchors[i].classList.remove("active");
        }
    }
}

function filterFunction() {
    var input, filter, ul, li, a;
    openAllDropdownContainers();
    input = document.getElementById("searchInput");
    filter = input.value.toUpperCase();
    for (var i = 0; i < anchors.length; i++) {
        var txtValue = anchors[i].textContent || anchors[i].innerText;
        if (txtValue.toUpperCase().indexOf(filter) > -1) {
            anchors[i].style.display = "block";
        } else {
            anchors[i].style.display = "none";
        }
    }
}

function clearSearch() {
    var input, filter;
    input = document.getElementById("searchInput");
    if (input.value === "") {
        return;
    }
    filter = input.value.toUpperCase();
    input.value = "";
    for (var i = 0; i < anchors.length; i++) {
        if (anchors[i].style.display = "none") {
            anchors[i].style.display = "block";
        }
    }
    queryDropdownContainer(filter, false);
}

function queryDropdownContainer(filter, expand) {
    var found = false;
    var elem;
    var hashFound = false;
    document.querySelectorAll(".dropdown-container").forEach(a => {
        if (found) {
            return;
        }
        var txtValue = a.textContent || a.innerText;
        a.childNodes.forEach(c => {
            if (c.hash === window.location.hash) {
                hashFound = true;
                elem = a;
                return;
            }
        });
        if (txtValue.toUpperCase().indexOf(filter) > -1 && hashFound) {
            found = true;
            return;
        }
    });
    if (!found && !hashFound) {
        closeAllDropdownContainers();
        return false;
    } else {
        var prevElem = elem.previousElementSibling;
        if (expand) {
            elem.style.display = "block";
            prevElem.children["caret"].innerHTML = "&#8743;";
        } else {
            toggleDropdownContainers(prevElem);
        }
    }
}

function openAllDropdownContainers() {
    document.querySelectorAll(".dropdown-container").forEach(a => {
        a.style.display = "block";
        a.previousElementSibling.children["caret"].innerHTML = "&#8743;";
    });
}

function closeAllDropdownContainers() {
    document.querySelectorAll(".dropdown-container").forEach(a => {
        a.style.display = "none";
        a.previousElementSibling.children["caret"].innerHTML = "&#8744;";
    });
}
