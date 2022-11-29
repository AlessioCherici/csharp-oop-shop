
namespace CSharpShop___Bonus
    {
    public class Prodotto
        {
        private string Nome;
        private int NumeroProdotto;
        private string Descrizione;
        private double Prezzo;
        private double Iva;

        public Prodotto()
            {
            this.Nome = "Prodotto";
            this.NumeroProdotto = 0;
            this.Descrizione = string.Empty;
            this.Prezzo = 0;
            this.Iva = 0.0f;
            }



        //------------------------- Metodi Get -------------------------

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

        public double GetIva()
            {
            return this.Iva;
            }

        //------------------------- Metodi Set -------------------------

        public void SetNumeroProdotto()
            {
            this.NumeroProdotto = GeneratoreRGN();
            }

        public void SetPrezzo(double Prezzo)
            {
            this.Prezzo = Prezzo;
            }

        public void SetDescrizione(string Descrizione)
            {
            this.Descrizione = Descrizione;
            }

        public void SetNome(string Nome)
            {
            this.Nome = Nome;
            }

        public void SetIva(double Iva)
            {
            this.Iva = Iva;
            }


        //------------------------- Metodi Calcoli Vari -------------------------
        public int GeneratoreRGN()
            {
            Random NumeroRNGProdotto = new Random();
            int CodiceProdotto = NumeroRNGProdotto.Next(100000000);
            return CodiceProdotto;
            }
        public double PrezzoIvato(double Prezzo, double Iva)
            {
            double ValoreIva = Prezzo * Iva / 100;
            double PrezzoIvato = Prezzo + ValoreIva;
            return Math.Round(PrezzoIvato, 2);
            }

        //------------------------- Metodo Stampa Prodotto -------------------------

        public void StampaTutto()
            {
            Console.WriteLine("---------" + this.Nome + "---------" + "\n");
            Console.WriteLine("Descrizione: " + this.Descrizione);
            Console.WriteLine("Codice Prodotto: " + this.NumeroProdotto.ToString().PadLeft(12, '0'));      //Stampa di codice prodotto in padding left con leading 0's     *BONUS*
            Console.WriteLine("Prezzo prodotto: " + this.Prezzo + " Euro");
            Console.WriteLine("Iva prodotto: " + this.Iva + "%");
            Console.WriteLine("Prezzo con Iva: " + PrezzoIvato(this.Prezzo, this.Iva) + "\n");
            }
        }
    }
