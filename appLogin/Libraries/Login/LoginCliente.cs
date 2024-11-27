using appLogin.Models;
using Microsoft.AspNetCore.DataProtection.KeyManagement;

namespace appLogin.Libraries.Login
{
    public class LoginCliente
    {
        private string Key = "Login.Cliente";
        private Sessao.Sessao _sessao;
        public LoginCliente(Sessao.Sessao sessao)
        {
            _sessao = sessao;
        }
        public void Login(Cliente cliente )
        {
            string clienteJSONString = JsonConvert.SerializeObject( cliente ); 

            _sessao.Cadastrar(Key, clienteJSONString);

        }
    }
}
