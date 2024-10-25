document.getElementById('ponto-formulario').addEventListener('submit', function(event){
    const entrada = document.getElementById('hora-entrada').value;
    const saida = document.getElementById('hora-saida').value;
    if (entrada >= saida) {
        alert('Erro: A hora de saída deve ser após a hora de entrada.');
        event.preventDefault();
    }
});