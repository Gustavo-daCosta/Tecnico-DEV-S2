import React from 'react';
// Import dos componentes de rota
import { BrowserRouter, Routes, Route } from 'react-router-dom';
// Import das páginas
import HomePage from './pages/HomePage/HomePage';
import LoginPage from './pages/LoginPage/LoginPage';
import ProdutoPage from './pages/ProdutoPage/ProdutoPage';

const Rotas = () => { // Criar a estrutura de rotas
    return (
        <BrowserRouter>
            <Routes>
                <Route element={<HomePage/>} path="/" exact />
                <Route element={<LoginPage/>} path="/login" />
                <Route element={<ProdutoPage/>} path="/produtos" />
            </Routes>
        </BrowserRouter>
    );
};

export default Rotas;