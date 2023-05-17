document.addEventListener("DOMContentLoaded", function () {
    // Seleciona o botão para abrir o modal
    var btn = document.getElementById("myBtn");

    // Seleciona o modal
    var modal = document.getElementById("background-black");

    // Seleciona o botão para fechar o modal
    var span = document.getElementsByClassName("fechar-modal")[0];

    // Função para abrir o modal
    function abrirModal() {
        modal.style.display = "block";
    }

    // Função para fechar o modal
    function fecharModal() {
        modal.style.display = "none";
    }

    // Abre o modal quando o botão for clicado
    btn.addEventListener("click", abrirModal);

    // Fecha o modal quando o botão de fechar for clicado
    span.addEventListener("click", fecharModal);

    // Fecha o modal quando o usuário clicar fora do modal
    window.addEventListener("click", function (event) {
        if (event.target == modal) {
            fecharModal();
        }
    });
});
