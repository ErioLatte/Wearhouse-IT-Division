const addPopup = document.getElementsByClassName("add-popup-categories")[0];
const editPopup = document.getElementsByClassName("edit-popup-categories")[0];
const deletePopup = document.getElementsByClassName("delete-popup-categories")[0];

const categories = document.getElementsByClassName("container-categories")[0];

function openAddPopup() {
    addPopup.style.display = "flex";
    categories.style.display = "none";
}

function closeAddPopup() {
    addPopup.style.display = "none";
    categories.style.display = "flex";
}

function openEditPopup() {
    editPopup.style.display = "flex";
    categories.style.display = "none";
}

function closeEditPopup() {
    editPopup.style.display = "none";
    categories.style.display = "flex";
}

function openDeletePopup() {
    deletePopup.style.display = "flex";
    categories.style.display = "none";
}

function closeDeletePopup() {
    deletePopup.style.display = "none";
    categories.style.display = "flex";
}