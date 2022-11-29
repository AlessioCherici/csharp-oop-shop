
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

using CSharpShop___Bonus;

/*Prodotto Prodotto1 = new Prodotto();

Console.WriteLine("Benvenuto nel sistema di generazione prodotti");

Console.WriteLine("Inserisci il nome del prodotto che vuoi registrare");
string NomeInserito = Console.ReadLine();
Prodotto1.SetNome(NomeInserito);

Prodotto1.SetNumeroProdotto();


Console.WriteLine("Ora inserisci la descrizione del prodotto");
string DescrizioneInserita = (Console.ReadLine());
Prodotto1.SetDescrizione(DescrizioneInserita);

Console.WriteLine("Ora inserisci il prezzo del prodotto");
double PrezzoInSerito = double.Parse(Console.ReadLine());
Prodotto1.SetPrezzo(PrezzoInSerito);

Console.WriteLine("Ora inserisci l'Iva del prodotto (senza il simbolo %)");
double IvaInserita = double.Parse(Console.ReadLine());
Prodotto1.SetIva(IvaInserita);

Prodotto1.StampaTutto();*/

List<Prodotto> list = new List<Prodotto>();

Prodotto Prodotto2 = new Prodotto();
Prodotto2.SetNome("Outer Wilds");                     //Dovresti davvero giocarlo Emanuele, e' un capolavoro!
Prodotto2.SetNumeroProdotto();
Prodotto2.SetDescrizione("Outer Wilds e' un videogioco di esplorazione spaziale," + "\n" + 
    "incentrato sullo svolgimento di una trama misteriosa ed intricata!");
Prodotto2.SetPrezzo(22.90d);                          //Veramente poco,considerato il capolavoro che giocherai!
Prodotto2.SetIva(22);
Prodotto2.StampaTutto();
list.Add(Prodotto2);

Prodotto Prodotto3 = new Prodotto();
Prodotto3.SetNome("Doom Eternal");                     
Prodotto3.SetNumeroProdotto();
Prodotto3.SetDescrizione("Doom Eternal è uno sparatutto in prima persona in cui interpreti" + "\n" +
    "il ruolo del DemonSlayer, atto a salvare il mondo da un invasione di demoni!");
Prodotto3.SetPrezzo(56d);                          
Prodotto3.SetIva(22);
Prodotto3.StampaTutto();
list.Add(Prodotto3);

Prodotto Prodotto4 = new Prodotto();
Prodotto4.SetNome("Escape From Tarkov");
Prodotto4.SetNumeroProdotto();
Prodotto4.SetDescrizione("Escape From Tarkov è l' esperienza simulativa FPS definitiva, ambientato in una" + "\n" +
    "zona ristretta in Russia, dove non ci sono regole e lo scopo principale e' sopravvivere!");
Prodotto4.SetPrezzo(45.50d);
Prodotto4.SetIva(22);
Prodotto4.StampaTutto();
list.Add(Prodotto4);

Prodotto Prodotto5 = new Prodotto();
Prodotto5.SetNome("CyberPunk 2077");
Prodotto5.SetNumeroProdotto();
Prodotto5.SetDescrizione("CyberPunk 2077 e' ambientato in un lontano futuro distopico disfattista dove le persone" + "\n" +
    "indossano augment cibernetici per incrementare forza, intelligenza, velocità," + "\n" + "spesso a discapito della loro salute /sanità mentale");
Prodotto5.SetPrezzo(35.60d);
Prodotto5.SetIva(22);
Prodotto5.StampaTutto();
list.Add(Prodotto5);















