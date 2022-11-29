
/*Nel progetto CSharpShop , creare la classe Prodotto che gestisce i prodotti del vostro shop.
Un prodotto è caratterizzato da:
codice(numero intero)
nome
descrizione
prezzo
iva


Usate opportunamente i livelli di accesso (public, private), i costruttori, i metodi getter e setter ed eventuali altri metodi di “utilità” per fare in modo che:
alla creazione di un nuovo prodotto il codice sia valorizzato con un numero random.
Il codice prodotto sia accessibile solo in lettura
Gli altri attributi siano accessibili sia in lettura che in scrittura
Il prodotto esponga sia un metodo per avere il prezzo base che uno per avere il prezzo comprensivo di iva.

Il prodotto esponga un metodo per avere il nome esteso, ottenuto concatenando codice + nome
Testate poi i vostri oggetti Prodotto, istanziandoli e provando ad interagirci con loro per testare tutti i metodi che avete previsto e implementato.*/

using CSharpShop;

Prodotto Prodotto1 = new Prodotto();

Console.WriteLine("Benvenuto nel sistema di generazione prodotti");

Console.WriteLine("Inserisci il nome del prodotto che vuoi registrare");
string NomeInserito = Console.ReadLine();
Prodotto1.SetNome(NomeInserito);

Prodotto1.SetNumeroProdotto();


Console.WriteLine("Ora inserisci la descrizione del prodotto");
string DescrizioneInserita =(Console.ReadLine());
Prodotto1.SetDescrizione(DescrizioneInserita);

Console.WriteLine("Ora inserisci il prezzo del prodotto");
double PrezzoInSerito = double.Parse(Console.ReadLine());
Prodotto1.SetPrezzo(PrezzoInSerito);

Console.WriteLine("Ora inserisci l'Iva del prodotto (senza il simbolo %)");
double IvaInserita = double.Parse(Console.ReadLine());
Prodotto1.SetIva(IvaInserita);

Prodotto1.StampaTutto();











