//LatihanPolimorfisme2
Console.WriteLine("-----Simulasi Checkout-----");
Console.WriteLine("Pilih metode:");
Console.WriteLine("1. Bank Transfer");
Console.WriteLine("2. E-Wallet");
Console.WriteLine("3. Kartu Kredit");

Console.Write("Pilihan anda : ");
int pilihan = int.Parse(Console.ReadLine());

switch (pilihan)
{
    case 1:
        BankTransfer bankTransfer = new BankTransfer();
        bankTransfer.Bayar(100000);
        break;
    case 2:
        EWallet eWallet = new EWallet();
        eWallet.Bayar(100000);
        break;
    case 3:
        KartuKredit kartuKredit = new KartuKredit();
        kartuKredit.Bayar(100000);
        break;
    default:
        Console.WriteLine("Pilihan tidak valid");
        break;

}
class MetodePembayaran
{
    public virtual void Bayar(int jumlah)
    {
        Console.WriteLine($"...Memproses Pembayaran...");
    }
}

class BankTransfer : MetodePembayaran
{
    public override void Bayar(int jumlah)
    {
        Console.WriteLine($"Silahkan transfer sejumlah Rp {jumlah} ke nomor rekening 12345678");
    }
}

class EWallet : MetodePembayaran
{
    public override void Bayar(int jumlah)
    {
        Console.WriteLine($"Saldo terpotong sejumlah Rp {jumlah}");
    }
}
class KartuKredit : MetodePembayaran
{
    public override void Bayar(int jumlah)
    {
        Console.WriteLine($"Transaksi sejumlah Rp {jumlah} berhasil di lakukan");
    }
}