
       Console.Write("masukkan angka: ");
int inputHari = Convert.ToInt32(Console.ReadLine());
      
        if (inputHari >= 1 && inputHari <= 7)
        {
            string namaHari = "";
            string statusHari = "";

        
            switch (inputHari)
            {
                case 1:
                    namaHari = "Senin";
                    statusHari = "Hari Kerja (Weekday)";
                    break;
                case 2:
                    namaHari = "Selasa";
                    statusHari = "Hari Kerja (Weekday)";
                    break;
                case 3:
                    namaHari = "Rabu";
                    statusHari = "Hari Kerja (Weekday)";
                    break;
                case 4:
                    namaHari = "Kamis";
                    statusHari = "Hari Kerja (Weekday)";
                    break;
                case 5:
                    namaHari = "Jumat";
                    statusHari = "Hari Kerja (Weekday)";
                    break;
                case 6:
                    namaHari = "Sabtu";
                    statusHari = "Hari Libur Akhir Pekan (Weekend)";
                    break;
                case 7:
                    namaHari = "Minggu";
                    statusHari = "Hari Libur Akhir Pekan (Weekend)";
                    break;
            }

            Console.WriteLine($"Angka {inputHari} adalah hari {namaHari}.");
            Console.WriteLine($"Status: {statusHari}");
        }
        else
        {
            
            Console.WriteLine("Error: Input tidak valid! Masukkan angka antara 1 sampai 7.");
        }
    