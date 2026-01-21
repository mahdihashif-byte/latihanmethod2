int jumlahitem, hargaItem;
decimal diskon, totalbayar;

decimal hitungdiskon(int jml_item)
{
    if (jml_item == 5)
        return 50000;
    else if (jml_item == 10)
        return 75000;
    else
        return 0;
}

decimal hitungTotalBayar(int jml_item, int harga_item, decimal diskon)
{
    return jml_item * harga_item - diskon;
}

Console.WriteLine("-_- Selamat datang di kasir -_- ");
Console.Write("Masukkan jumlah item di beli:");
jumlahitem = int.Parse(Console.ReadLine());

Console.Write("Masukkan harga item: ");
hargaItem = int.Parse(Console.ReadLine());

diskon = hitungdiskon(jumlahitem);

totalbayar = hitungTotalBayar(jumlahitem, hargaItem, diskon);

Console.WriteLine($"Total bayar: Rp {totalbayar}");