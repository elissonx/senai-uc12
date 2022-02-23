using System.Text.RegularExpressions;
using CADASTRO_PESSOA_FS1.Interfaces;

namespace CADASTRO_PESSOA_FS1.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        public string cnpj { get; set; }

        public string razaoSocial { get; set; }


        public override float PagarImposto(float rendimento)
        {
            throw new System.NotImplementedException();
        }

        //XX.XXX.XXX/0001-XX  - XXXXXXXX0001XX
        public bool ValidarCnpj(string cnpj)
        {
            if (Regex.IsMatch(cnpj, @"(^(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})|(\d{14})$)"))
            {
                if (cnpj.Length == 18) //validando com os caracteres . / e -
                {
                    if (cnpj.Substring(11, 4) == "0001") //substring para validar um trecho da string
                    {
                        return true;
                    }
                }
                else if (cnpj.Length == 14) //validando sem caracteres, somente números
                {
                    if (cnpj.Substring(8, 4) == "0001" )
                    {
                        return true;   
                    }
                } 
            }
            return false;
        }
    }
}
