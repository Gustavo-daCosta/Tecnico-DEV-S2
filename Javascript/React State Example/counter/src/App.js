import React, { useState } from 'react';

function Contador() {
  // Defina o state utilizando o useState (hook)
  const [contagem, setContagem] = useState(0);

  // Define um método para incrementar a contagem
  const incremento = () => {
    setContagem(contagem + 1);
  };

  // Define um método para decrementar a contagem
  const decremento = () => {
    setContagem(contagem - 1);
  };

  return (
    <main>
      <div class="contador">
        <h1 class="titulo">Contador</h1>
        <div class="numero">
          <h1>{contagem}</h1>
        </div>
        <div class="botoes">
          <button onClick={decremento}>-</button>
          <button onClick={incremento}>+</button>
        </div>
      </div>
    </main>
  );
}

export default Contador;
