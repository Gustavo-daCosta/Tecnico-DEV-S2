import React from "react";
import './card.css';

const CardEvento = (props) => {
    return <div className="cardEvento">
        <h2 className="cardEvento__titulo">{props.titulo}</h2>
        <p className="cardEvento__descricao">{props.descricao}</p>
        <a href="" className={
            props.desabilitado
            ? "cardEvento__conectar"
            : "cardEvento__conectar cardEvento__conectar--desabilitado"
        }>Conectar</a>
    </div>
}

export default CardEvento;