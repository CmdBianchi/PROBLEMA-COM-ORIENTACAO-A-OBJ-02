using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PROBLEMA_COM_ORIENTACAO_A_OBJ_02{
    //----------------------- OBJ PRODUTO -----------------------//
    class Produto{ //----> Atributos da classe
        public string Nome;
        public double Preco;
        public int Quantidade;        
        //--------------------------------------------//
        public double ValorTotalEmEstoque(){//---> Métodos da classe
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade){
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade){
            Quantidade -= quantidade;
        }
        public override string ToString(){
            return Nome
            + ", $ "
            + Preco.ToString("F2")
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2");
        }
        //--------------------------------------------//
        //--->END
    }
}
