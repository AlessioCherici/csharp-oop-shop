using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShop
    {
    public class Prodotto
        {
        private string Nome;
        private int NumeroProdotto;
        private string Descrizione;
        private double Prezzo;
        private float Iva;

        public Prodotto()
            {
            this.Nome = "Prodotto";
            this.NumeroProdotto = 0;
            this.Descrizione = string.Empty;
            this.Prezzo = 0;
            this.Iva = 0.0f;
            }



        //------------------------- Metodi -------------------------

        public int GeneratoreRGN()
            {
            Random NumeroRNGProdotto = new Random();
            int CodiceProdotto = NumeroRNGProdotto.Next(100000000);
            return CodiceProdotto;
            }

        public double GetPrezzo()
            {
            return this.Prezzo;
            }

        public string GetNome()
            {
            return this.Nome;
            }

        public int GetNumeroProdotto()
            {
            return NumeroProdotto;
            }

        public float GetIva()
            {
            return this.Iva;
            }

        public void SetPrezzo(double Prezzo)
            {
            this.Prezzo = Prezzo;
            }

        public void SetDescrizione(string descrizione )
            {
            this.Descrizione = Descrizione;
            }

        public void SetNome(string Nome)
            {
            this.Nome = Nome;
            }

        public void SetIva(float Iva)
            {
            this.Iva = Iva;
            }

        }
    }
