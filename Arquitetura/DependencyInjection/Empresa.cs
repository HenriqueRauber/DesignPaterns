using System;

namespace DependencyInjection
{
    /// <summary>
    /// Constructor
    /// </summary>
    public class Empresa_Constructor
    {
        public int Codigo { get; set; }
        public string RazaoSocial { get; set; }
        
        public IObjetoEndereco Endereco { get; set; }

        public Empresa_Constructor(IObjetoEndereco objeto)
        {
            Endereco = objeto;
        }
    }
    
    /// <summary>
    /// Gets and Sets
    /// </summary>
    public class Empresa_GetsAndSets
    {
        public int Codigo { get; set; }
        public string RazaoSocial { get; set; }
        private IObjetoEndereco _endereco;
        public IObjetoEndereco Endereco
        {
            get
            {
                return _endereco;
            }
            set
            {
                _endereco = value;
            }
        } 
    }

    /// <summary>
    /// Interface implementation
    /// </summary>
    public class Empresa_InterfaceImplementation : IObjetoEnderecoIJ
    {
        public int Codigo { get; set; }
        public string RazaoSocial { get; set; }

        private IObjetoEndereco Endereco { get; set; }

        public void setEndereco(IObjetoEndereco obj)
        {
            this.Endereco = obj;
        }
    }

    /// <summary>
    /// Service locator
    /// </summary>
    public class Empresa_ServiceLocator 
    {
        public int Codigo { get; set; }
        public string RazaoSocial { get; set; }

        private IObjetoEndereco Endereco { get; set; }
        
        public Empresa_ServiceLocator()
        {
            Endereco = Localizador.getEndereco();
        }
    } 
}
