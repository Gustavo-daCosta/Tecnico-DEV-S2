namespace webapi.inlock.codefirst.Utils
{
    public static class Criptografia
    {
        /// <summary>
        /// Gera uma Hash a partir de uma senha
        /// </summary>
        /// <param name="senha">Senha que receberá o Hash</param>
        /// <returns>Senha criptografada com a Hash</returns>
        public static string GerarHash(string senha)
            => BCrypt.Net.BCrypt.HashPassword(senha);

        /// <summary>
        /// Verifica se a hash da senha informada é igual a hash salva no banco de dados
        /// </summary>
        /// <param name="senhaForm">Senha passada no form de login</param>
        /// <param name="senhaBanco">Senha cadastrada no banco de dados</param>
        /// <returns>True ou False (caso o hash seja válido ou não)</returns>
        public static bool CompararHash(string senhaForm, string senhaBanco)
            => BCrypt.Net.BCrypt.Verify(senhaForm, senhaBanco);


    }
}
