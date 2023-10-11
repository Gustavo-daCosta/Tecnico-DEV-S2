function mostrarNickname() {
    event.preventDefault();
    let nickname = document.getElementById("nickname").value;
    document.getElementById("mostrar-nickname").replaceWith(nickname);
}