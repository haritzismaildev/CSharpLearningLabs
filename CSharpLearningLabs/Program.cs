using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// ======================================================================================
// C# Learning Lab - Interaktif Console App
// ======================================================================================
 class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8; // UTF-8 desteği sağlamak için çıktı kodlamasını ayarlayın
        while(true)
        {
            MenuUtama();
            string pilihan = Console.ReadLine()?.Trim();
            switch (pilihan)
            {
                case "1": Menu_Bagian1_LogikaKondisi(); break;
                case "2": Menu_Bagian2_ArrayData(); break;
                case "3": Menu_Bagian3_StringManipulasi(); break;
                case "4": Menu_Bagian4_OOP(); break;
                case "5": Menu_Bagian5_CodingTest(); break;
                case "0": Keluar(); return;
                default: PesanTidakValid(); break;
            }
        }
    }

    // -- MENU UTAMA -----------------------------------------------------------------------------
    static void MenuUtama()
    {
        Console.Clear();
        Warna(ConsoleColor.Cyan, () =>
        {
            Console.WriteLine("================================================");
            Console.WriteLine("   C# Learning Lab - Interaktif Console App");
            Console.WriteLine("  Belajar Sambil Langsung Uji Setiap Logika");
            Console.WriteLine("================================================");
        });
        Console.WriteLine();
        MenuItem("1", "Bagian 1", "Logika & Kondisi Dasar (4 soal)");
        MenuItem("2", "Bagian 2", "Array & Manipulasi Data (4 soal)");
        MenuItem("3", "Bagian 3", "String Manipulation (3 soal)");
        MenuItem("4", "Bagian 4", "OOP - Dunia Nyata (2 soal)");
        MenuItem("5", "Bagian 5", "Simulasi Koding Test Real (3 soal)");
        Console.WriteLine();
        Warna(ConsoleColor.Red, () => Console.WriteLine("  [0] Keluar"));
        Console.WriteLine();
        Console.Write(" Pilih bagian [0-5]: ");
    }

    // ===========================================================================================
    // BAGIAN 1: LOGIKA & KONDISI
    // ===========================================================================================
    static void Menu_Bagian1_LogikaKondisi()
    {
        while (true)
        {
            HeaderBagian("BAGIAN 1 — LOGIKA & KONDISI DASAR", ConsoleColor.Green);
            MenuItem("1", "Soal 01", "Cek Ganjil atau Genap");
            MenuItem("2", "Soal 02", "FizzBuzz (1-N)");
            MenuItem("3", "Soal 03", "Cek Tahun Kabisat");
            MenuItem("4", "Soal 04", "Kalkulator Interaktif");
            Console.WriteLine();
            Warna(ConsoleColor.Yellow, () => Console.WriteLine("  [0] Kembali ke Menu Utama"));
            Console.WriteLine();
            Console.Write("  Pilih soal [0-4]: ");
            string p = Console.ReadLine()?.Trim();
            switch (p)
            {
                case "1": Soal01_GanjilGenap(); break;
                case "2": Soal02_FizzBuzz(); break;
                case "3": Soal03_TahunKabisat(); break;
                case "4": Soal04_Kalkulator(); break;
                case "0": return;
                default: PesanTidakValid(); break;
            }
        }
    }

    // ─────────────────────────────────────────────────────────────
    // BAGIAN 2: ARRAY
    // ─────────────────────────────────────────────────────────────
    static void Menu_Bagian2_ArrayData()
    {
        while (true)
        {
            HeaderBagian("BAGIAN 2 — ARRAY & MANIPULASI DATA", ConsoleColor.Green);
            MenuItem("1", "Soal 05", "Cari Max, Min & Rata-rata Array");
            MenuItem("2", "Soal 06", "Balik Urutan Array (Reverse)");
            MenuItem("3", "Soal 07", "Hapus Duplikat dari Array");
            MenuItem("4", "Soal 08", "Two Sum — Cari Pasangan Target");
            Console.WriteLine();
            Warna(ConsoleColor.Yellow, () => Console.WriteLine("  [0] Kembali ke Menu Utama"));
            Console.WriteLine();
            Console.Write("  Pilih soal [0-4]: ");
            string p = Console.ReadLine()?.Trim();
            switch (p)
            {
                case "1": Soal05_MaxMinAvg(); break;
                case "2": Soal06_ReverseArray(); break;
                case "3": Soal07_HapusDuplikat(); break;
                case "4": Soal08_TwoSum(); break;
                case "0": return;
                default: PesanTidakValid(); break;
            }
        }
    }

    // ─────────────────────────────────────────────────────────────
    // BAGIAN 3: STRING
    // ─────────────────────────────────────────────────────────────
    static void Menu_Bagian3_StringManipulasi()
    {
        while (true)
        {
            HeaderBagian("BAGIAN 3 — STRING MANIPULATION", ConsoleColor.Yellow);
            MenuItem("1", "Soal 09", "Cek Palindrome");
            MenuItem("2", "Soal 10", "Run-Length Encoding (soal coding test nyata!)");
            MenuItem("3", "Soal 11", "Anagram Checker");
            Console.WriteLine();
            Warna(ConsoleColor.Yellow, () => Console.WriteLine("  [0] Kembali ke Menu Utama"));
            Console.WriteLine();
            Console.Write("  Pilih soal [0-3]: ");
            string p = Console.ReadLine()?.Trim();
            switch (p)
            {
                case "1": Soal09_Palindrome(); break;
                case "2": Soal10_RLE(); break;
                case "3": Soal11_Anagram(); break;
                case "0": return;
                default: PesanTidakValid(); break;
            }
        }
    }

    // ─────────────────────────────────────────────────────────────
    // BAGIAN 4: OOP
    // ─────────────────────────────────────────────────────────────
    static void Menu_Bagian4_OOP()
    {
        while (true)
        {
            HeaderBagian("BAGIAN 4 — OOP: DUNIA NYATA", ConsoleColor.Magenta);
            MenuItem("1", "Soal 12", "BankAccount — Encapsulation & Validasi");
            MenuItem("2", "Soal 13", "Sistem Nilai Mahasiswa — OOP + LINQ");
            Console.WriteLine();
            Warna(ConsoleColor.Yellow, () => Console.WriteLine("  [0] Kembali ke Menu Utama"));
            Console.WriteLine();
            Console.Write("  Pilih soal [0-2]: ");
            string p = Console.ReadLine()?.Trim();
            switch (p)
            {
                case "1": Soal12_BankAccount(); break;
                case "2": Soal13_SistemNilai(); break;
                case "0": return;
                default: PesanTidakValid(); break;
            }
        }
    }

    // ─────────────────────────────────────────────────────────────
    // BAGIAN 5: CODING TEST
    // ─────────────────────────────────────────────────────────────
    static void Menu_Bagian5_CodingTest()
    {
        while (true)
        {
            HeaderBagian("BAGIAN 5 — SIMULASI CODING TEST NYATA", ConsoleColor.Red);
            Warna(ConsoleColor.DarkYellow, () =>
                Console.WriteLine("  Tip: Kerjakan dengan timer sebelum melihat output!\n"));
            MenuItem("1", "Soal 14", "Valid Parentheses — Stack Pattern");
            MenuItem("2", "Soal 15", "Data Transaksi — GroupBy & Sort");
            MenuItem("3", "Soal 16", "Filter & Sort Array dengan Pola (persis soal interview kemarin!)");
            Console.WriteLine();
            Warna(ConsoleColor.Yellow, () => Console.WriteLine("  [0] Kembali ke Menu Utama"));
            Console.WriteLine();
            Console.Write("  Pilih soal [0-3]: ");
            string p = Console.ReadLine()?.Trim();
            switch (p)
            {
                case "1": Soal14_ValidParentheses(); break;
                case "2": Soal15_DataTransaksi(); break;
                case "3": Soal16_FilterSortArray(); break;
                case "0": return;
                default: PesanTidakValid(); break;
            }
        }
    }

    // ═════════════════════════════════════════════════════════════
    // IMPLEMENTASI SOAL 01: GANJIL / GENAP
    // ═════════════════════════════════════════════════════════════
    static void Soal01_GanjilGenap()
    {
        HeaderSoal("SOAL 01", "Cek Ganjil atau Genap",
            "Masukkan angka, program akan cek GANJIL atau GENAP.",
            "Pola: angka % 2 == 0 → GENAP. Sisanya → GANJIL.");

        while (true)
        {
            Console.Write("\n  Masukkan angka (atau 'x' untuk kembali): ");
            string input = Console.ReadLine()?.Trim();
            if (input?.ToLower() == "x") break;

            if (!int.TryParse(input, out int angka))
            { PesanError("Input harus berupa angka bulat!"); continue; }

            // ── LOGIKA ──
            string hasil = angka % 2 == 0 ? "GENAP" : "GANJIL";
            string sisa = $"(sisa bagi 2 = {angka % 2})";

            // ── OUTPUT ──
            Console.WriteLine();
            TampilkanBox(new[] {
                $"Input  : {angka}",
                $"Hasil  : {angka} adalah {hasil} {sisa}",
            }, angka % 2 == 0 ? ConsoleColor.Cyan : ConsoleColor.Magenta);

            // ── PENJELASAN ──
            TampilkanPenjelasan(new[] {
                $"Langkah 1 → Hitung sisa bagi 2 : {angka} % 2 = {angka % 2}",
                $"Langkah 2 → Jika sisa = 0 → GENAP, jika sisa = 1 → GANJIL",
                $"Kesimpulan → {angka} % 2 = {angka % 2} → {hasil}",
            });
        }
    }

    // ═════════════════════════════════════════════════════════════
    // SOAL 02: FIZZBUZZ
    // ═════════════════════════════════════════════════════════════
    static void Soal02_FizzBuzz()
    {
        HeaderSoal("SOAL 02", "FizzBuzz",
            "Masukkan N, program tampilkan 1-N dengan aturan FizzBuzz.",
            "Kelipatan 3=Fizz, kelipatan 5=Buzz, keduanya=FizzBuzz.");

        while (true)
        {
            Console.Write("\n  Masukkan N (atau 'x' untuk kembali): ");
            string input = Console.ReadLine()?.Trim();
            if (input?.ToLower() == "x") break;

            if (!int.TryParse(input, out int n) || n < 1)
            { PesanError("Masukkan angka bulat positif!"); continue; }

            Console.WriteLine();
            Warna(ConsoleColor.Cyan, () => Console.WriteLine($"  ── FizzBuzz 1 sampai {n} ──\n"));

            // ── LOGIKA ──
            int countFizz = 0, countBuzz = 0, countFizzBuzz = 0, countAngka = 0;
            for (int i = 1; i <= n; i++)
            {
                string label;
                ConsoleColor warna;
                if (i % 3 == 0 && i % 5 == 0)
                { label = "FizzBuzz"; warna = ConsoleColor.Magenta; countFizzBuzz++; }
                else if (i % 3 == 0)
                { label = "Fizz"; warna = ConsoleColor.Green; countFizz++; }
                else if (i % 5 == 0)
                { label = "Buzz"; warna = ConsoleColor.Yellow; countBuzz++; }
                else
                { label = i.ToString(); warna = ConsoleColor.Gray; countAngka++; }

                Console.Write("  ");
                Warna(warna, () => Console.Write($"{label,-10}"));
                if (i % 8 == 0) Console.WriteLine();
            }
            Console.WriteLine("\n");

            // ── STATISTIK ──
            TampilkanBox(new[] {
                $"Total angka  : {n}",
                $"Fizz         : {countFizz} angka (kelipatan 3 saja)",
                $"Buzz         : {countBuzz} angka (kelipatan 5 saja)",
                $"FizzBuzz     : {countFizzBuzz} angka (kelipatan 3 & 5)",
                $"Angka biasa  : {countAngka} angka",
            }, ConsoleColor.Cyan);

            TampilkanPenjelasan(new[] {
                "Urutan cek wajib: FizzBuzz DULU, baru Fizz, baru Buzz",
                "Kenapa? Angka 15 = kelipatan 3 DAN 5. Kalau cek Fizz dulu,",
                "15 akan tercetak 'Fizz' padahal harusnya 'FizzBuzz'!",
            });
        }
    }

    // ═════════════════════════════════════════════════════════════
    // SOAL 03: TAHUN KABISAT
    // ═════════════════════════════════════════════════════════════
    static void Soal03_TahunKabisat()
    {
        HeaderSoal("SOAL 03", "Cek Tahun Kabisat",
            "Masukkan tahun, program cek apakah KABISAT atau bukan.",
            "Aturan: habis/400=ya, habis/100=tidak, habis/4=ya, lain=tidak.");

        while (true)
        {
            Console.Write("\n  Masukkan tahun (atau 'x' untuk kembali): ");
            string input = Console.ReadLine()?.Trim();
            if (input?.ToLower() == "x") break;

            if (!int.TryParse(input, out int tahun) || tahun < 1)
            { PesanError("Masukkan tahun yang valid!"); continue; }

            // ── LOGIKA dengan trace ──
            var langkah = new List<string>();
            bool hasilAkhir;

            if (tahun % 400 == 0)
            { langkah.Add($"{tahun} % 400 = 0 → KABISAT (aturan 1)"); hasilAkhir = true; }
            else if (tahun % 100 == 0)
            {
                langkah.Add($"{tahun} % 400 = {tahun % 400} (bukan 0)");
                langkah.Add($"{tahun} % 100 = 0 → BUKAN kabisat (aturan 2)"); hasilAkhir = false;
            }
            else if (tahun % 4 == 0)
            {
                langkah.Add($"{tahun} % 400 = {tahun % 400} (bukan 0)");
                langkah.Add($"{tahun} % 100 = {tahun % 100} (bukan 0)");
                langkah.Add($"{tahun} % 4 = 0 → KABISAT (aturan 3)"); hasilAkhir = true;
            }
            else
            {
                langkah.Add($"{tahun} % 400 = {tahun % 400} (bukan 0)");
                langkah.Add($"{tahun} % 100 = {tahun % 100} (bukan 0)");
                langkah.Add($"{tahun} % 4 = {tahun % 4} (bukan 0)");
                langkah.Add("Tidak memenuhi aturan apapun → BUKAN kabisat"); hasilAkhir = false;
            }

            Console.WriteLine();
            TampilkanBox(new[] {
                $"Tahun  : {tahun}",
                $"Status : {(hasilAkhir ? "TAHUN KABISAT ✓" : "Bukan tahun kabisat ✗")}",
                $"Hari   : {(hasilAkhir ? "366 hari" : "365 hari")}",
            }, hasilAkhir ? ConsoleColor.Green : ConsoleColor.Red);

            TampilkanPenjelasan(langkah.ToArray());
        }
    }

    // ═════════════════════════════════════════════════════════════
    // SOAL 04: KALKULATOR INTERAKTIF
    // ═════════════════════════════════════════════════════════════
    static void Soal04_Kalkulator()
    {
        HeaderSoal("SOAL 04", "Kalkulator Interaktif",
            "Kalkulator dengan menu yang terus berjalan.",
            "Pilih operasi, masukkan 2 angka, lihat hasil + penjelasan.");

        while (true)
        {
            Console.WriteLine();
            Warna(ConsoleColor.Cyan, () => {
                Console.WriteLine("  ┌─ Pilih Operasi ─────────────────┐");
                Console.WriteLine("  │  1. Tambah (+)   2. Kurang (-)  │");
                Console.WriteLine("  │  3. Kali   (*)   4. Bagi  (/)  │");
                Console.WriteLine("  │  5. Modulo (%)   0. Kembali    │");
                Console.WriteLine("  └──────────────────────────────────┘");
            });
            Console.Write("  Pilihan: ");
            string pilihan = Console.ReadLine()?.Trim();
            if (pilihan == "0") break;
            if (!new[] { "1", "2", "3", "4", "5" }.Contains(pilihan))
            { PesanError("Pilih 1-5 atau 0 untuk kembali!"); continue; }

            double a = BacaDouble("  Angka pertama : ");
            double b = BacaDouble("  Angka kedua   : ");

            // ── LOGIKA ──
            double hasil = 0;
            string simbol = "";
            string penjelasan = "";
            bool valid = true;

            switch (pilihan)
            {
                case "1": hasil = a + b; simbol = "+"; penjelasan = $"{a} + {b} = {hasil}"; break;
                case "2": hasil = a - b; simbol = "-"; penjelasan = $"{a} - {b} = {hasil}"; break;
                case "3": hasil = a * b; simbol = "*"; penjelasan = $"{a} × {b} = {hasil}"; break;
                case "4":
                    if (b == 0)
                    { PesanError("Tidak bisa membagi dengan NOL!"); valid = false; }
                    else { hasil = a / b; simbol = "/"; penjelasan = $"{a} ÷ {b} = {hasil:F4}"; }
                    break;
                case "5":
                    if (b == 0)
                    { PesanError("Tidak bisa modulo dengan NOL!"); valid = false; }
                    else { hasil = a % b; simbol = "%"; penjelasan = $"{a} % {b} = {hasil} (sisa pembagian)"; }
                    break;
            }

            if (valid)
            {
                Console.WriteLine();
                TampilkanBox(new[] {
                    $"Operasi : {a} {simbol} {b}",
                    $"Hasil   : {penjelasan}",
                }, ConsoleColor.Green);
            }
        }
    }

    // ═════════════════════════════════════════════════════════════
    // SOAL 05: MAX MIN RATA-RATA
    // ═════════════════════════════════════════════════════════════
    static void Soal05_MaxMinAvg()
    {
        HeaderSoal("SOAL 05", "Max, Min & Rata-rata Array",
            "Masukkan angka dipisah koma. Program cari max, min, rata-rata.",
            "TANPA fungsi bawaan — logika manual agar paham cara kerjanya.");

        while (true)
        {
            Console.Write("\n  Masukkan angka (pisah koma, contoh: 5,3,8,1,9): ");
            string input = Console.ReadLine()?.Trim();
            if (input?.ToLower() == "x") break;

            int[] arr = ParseArrayInt(input);
            if (arr == null) continue;

            // ── LOGIKA MANUAL ──
            int max = arr[0], min = arr[0];
            double total = 0;
            var traceMax = new List<string>();
            var traceMin = new List<string>();

            for (int i = 0; i < arr.Length; i++)
            {
                total += arr[i];
                if (arr[i] > max)
                { traceMax.Add($"  arr[{i}]={arr[i]} > max={max} → update max={arr[i]}"); max = arr[i]; }
                if (arr[i] < min)
                { traceMin.Add($"  arr[{i}]={arr[i]} < min={min} → update min={arr[i]}"); min = arr[i]; }
            }

            double avg = total / arr.Length;

            Console.WriteLine();
            TampilkanBox(new[] {
                $"Array    : [{string.Join(", ", arr)}]",
                $"Maximum  : {max}",
                $"Minimum  : {min}",
                $"Total    : {total}",
                $"Rata-rata: {avg:F2}",
            }, ConsoleColor.Cyan);

            Console.WriteLine();
            Warna(ConsoleColor.DarkGray, () => {
                Console.WriteLine("  ── Trace Pencarian Max ──");
                Console.WriteLine($"  Mulai: asumsi max = arr[0] = {arr[0]}");
                traceMax.ForEach(s => Console.WriteLine(s));
                Console.WriteLine($"  Max akhir = {max}\n");
                Console.WriteLine("  ── Trace Pencarian Min ──");
                Console.WriteLine($"  Mulai: asumsi min = arr[0] = {arr[0]}");
                traceMin.ForEach(s => Console.WriteLine(s));
                Console.WriteLine($"  Min akhir = {min}");
            });

            Console.Write("\n  Tekan Enter untuk lanjut...");
            Console.ReadLine();
        }
    }

    // ═════════════════════════════════════════════════════════════
    // SOAL 06: REVERSE ARRAY
    // ═════════════════════════════════════════════════════════════
    static void Soal06_ReverseArray()
    {
        HeaderSoal("SOAL 06", "Balik Urutan Array (Two Pointer)",
            "Masukkan array. Program balik urutan IN-PLACE dengan two pointer.",
            "Visualisasi setiap langkah swap ditampilkan.");

        while (true)
        {
            Console.Write("\n  Masukkan angka (pisah koma, atau 'x' kembali): ");
            string input = Console.ReadLine()?.Trim();
            if (input?.ToLower() == "x") break;

            int[] arr = ParseArrayInt(input);
            if (arr == null) continue;

            Console.WriteLine();
            Warna(ConsoleColor.Cyan, () => Console.WriteLine($"  Sebelum: [{string.Join(", ", arr)}]"));
            Console.WriteLine();

            // ── LOGIKA TWO POINTER dengan visualisasi ──
            int left = 0, right = arr.Length - 1;
            int step = 1;

            while (left < right)
            {
                Warna(ConsoleColor.DarkGray, () =>
                    Console.WriteLine($"  Step {step}: SWAP arr[{left}]={arr[left]} ↔ arr[{right}]={arr[right]}"));

                int temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;

                Warna(ConsoleColor.Gray, () =>
                    Console.WriteLine($"         Array: [{string.Join(", ", arr)}]"));

                left++; right--; step++;
            }

            Console.WriteLine();
            TampilkanBox(new[] { $"Sesudah  : [{string.Join(", ", arr)}]" }, ConsoleColor.Green);
            TampilkanPenjelasan(new[] {
                "Two Pointer: left mulai dari 0, right dari akhir",
                "Setiap iterasi: swap arr[left] & arr[right], lalu left++ dan right--",
                "Berhenti ketika left >= right (sudah ketemu di tengah)",
                "O(n/2) operasi swap = O(n) time, O(1) space (tidak buat array baru)",
            });
        }
    }

    // ═════════════════════════════════════════════════════════════
    // SOAL 07: HAPUS DUPLIKAT
    // ═════════════════════════════════════════════════════════════
    static void Soal07_HapusDuplikat()
    {
        HeaderSoal("SOAL 07", "Hapus Duplikat dari Array",
            "Masukkan array (boleh ada duplikat). Program tampilkan versi unik.",
            "Dua versi: HashSet (array bebas) vs Two Pointer (array sorted).");

        while (true)
        {
            Console.Write("\n  Masukkan angka (pisah koma, atau 'x' kembali): ");
            string raw = Console.ReadLine()?.Trim();
            if (raw?.ToLower() == "x") break;

            int[] arr = ParseArrayInt(raw);
            if (arr == null) continue;

            // ── VERSI A: HashSet ──
            var seen = new HashSet<int>();
            var hasilA = new List<int>();
            var traceA = new List<string>();

            foreach (int x in arr)
            {
                bool added = seen.Add(x);
                traceA.Add($"  {x}: {(added ? "BARU → masuk hasil" : "DUPLIKAT → dilewati")}");
                if (added) hasilA.Add(x);
            }

            // ── VERSI B: Two Pointer (array harus sorted) ──
            int[] sorted = (int[])arr.Clone();
            Array.Sort(sorted);
            var hasilB = new List<int> { sorted[0] };
            var traceB = new List<string> { $"  sorted[0]={sorted[0]} → masuk (elemen pertama)" };

            for (int i = 1; i < sorted.Length; i++)
            {
                if (sorted[i] != sorted[i - 1])
                { traceB.Add($"  sorted[{i}]={sorted[i]} ≠ sorted[{i - 1}]={sorted[i - 1]} → masuk"); hasilB.Add(sorted[i]); }
                else
                { traceB.Add($"  sorted[{i}]={sorted[i]} = sorted[{i - 1}]={sorted[i - 1]} → DUPLIKAT skip"); }
            }

            Console.WriteLine();
            TampilkanBox(new[] {
                $"Input    : [{string.Join(", ", arr)}]",
                $"Versi A (HashSet)    : [{string.Join(", ", hasilA)}]",
                $"Versi B (TwoPointer) : [{string.Join(", ", hasilB)}] (dari sorted)",
            }, ConsoleColor.Cyan);

            Console.WriteLine();
            Warna(ConsoleColor.DarkGray, () => {
                Console.WriteLine("  ── Trace Versi A (HashSet) ──");
                traceA.ForEach(Console.WriteLine);
                Console.WriteLine($"\n  ── Trace Versi B (sorted={string.Join(",", sorted)}) ──");
                traceB.ForEach(Console.WriteLine);
            });

            Console.Write("\n  Tekan Enter untuk lanjut...");
            Console.ReadLine();
        }
    }

    // ═════════════════════════════════════════════════════════════
    // SOAL 08: TWO SUM
    // ═════════════════════════════════════════════════════════════
    static void Soal08_TwoSum()
    {
        HeaderSoal("SOAL 08", "Two Sum — Cari Pasangan Target",
            "Input array + target. Cari 2 angka yang jumlahnya = target.",
            "Dua pendekatan: O(n²) naif vs O(n) optimal dengan Dictionary.");

        while (true)
        {
            Console.Write("\n  Masukkan array (pisah koma, atau 'x' kembali): ");
            string raw = Console.ReadLine()?.Trim();
            if (raw?.ToLower() == "x") break;

            int[] arr = ParseArrayInt(raw);
            if (arr == null) continue;

            Console.Write("  Masukkan target: ");
            if (!int.TryParse(Console.ReadLine(), out int target))
            { PesanError("Target harus angka!"); continue; }

            Console.WriteLine();

            // ── CARA NAIF O(n²) ──
            int[] hasilNaif = { -1, -1 };
            int stepsNaif = 0;
            for (int i = 0; i < arr.Length && hasilNaif[0] == -1; i++)
                for (int j = i + 1; j < arr.Length; j++)
                { stepsNaif++; if (arr[i] + arr[j] == target) { hasilNaif = new[] { i, j }; break; } }

            // ── CARA OPTIMAL O(n) ──
            var dict = new Dictionary<int, int>();
            int[] hasilOpt = { -1, -1 };
            int stepsOpt = 0;
            var traceOpt = new List<string>();

            for (int i = 0; i < arr.Length; i++)
            {
                stepsOpt++;
                int complement = target - arr[i];
                traceOpt.Add($"  i={i}, arr[i]={arr[i]}, cari complement={complement}");
                if (dict.ContainsKey(complement))
                {
                    hasilOpt = new[] { dict[complement], i };
                    traceOpt.Add($"  → KETEMU! dict[{complement}]=index {dict[complement]}");
                    break;
                }
                dict[arr[i]] = i;
                traceOpt.Add($"  → simpan dict[{arr[i]}]={i}");
            }

            // ── OUTPUT ──
            TampilkanBox(new[] {
                $"Array    : [{string.Join(", ", arr)}]",
                $"Target   : {target}",
                "",
                hasilNaif[0]==-1
                    ? "Naif  O(n²): Tidak ada pasangan ditemukan"
                    : $"Naif  O(n²): index [{hasilNaif[0]},{hasilNaif[1]}] → {arr[hasilNaif[0]]}+{arr[hasilNaif[1]]}={target}  ({stepsNaif} iterasi)",
                hasilOpt[0]==-1
                    ? "Optimal O(n): Tidak ada pasangan ditemukan"
                    : $"Optimal O(n): index [{hasilOpt[0]},{hasilOpt[1]}] → {arr[hasilOpt[0]]}+{arr[hasilOpt[1]]}={target}  ({stepsOpt} iterasi)",
            }, ConsoleColor.Cyan);

            Console.WriteLine();
            Warna(ConsoleColor.DarkGray, () => {
                Console.WriteLine("  ── Trace Cara Optimal ──");
                traceOpt.ForEach(Console.WriteLine);
            });
            Console.Write("\n  Tekan Enter untuk lanjut...");
            Console.ReadLine();
        }
    }

    // ═════════════════════════════════════════════════════════════
    // SOAL 09: PALINDROME
    // ═════════════════════════════════════════════════════════════
    static void Soal09_Palindrome()
    {
        HeaderSoal("SOAL 09", "Cek Palindrome",
            "Masukkan kata atau kalimat. Program cek apakah palindrome.",
            "Abaikan spasi & huruf besar/kecil. Two Pointer visualized.");

        while (true)
        {
            Console.Write("\n  Masukkan string (atau 'x' kembali): ");
            string input = Console.ReadLine();
            if (input?.ToLower() == "x") break;

            // ── BERSIHKAN ──
            string cleaned = new string(input.ToLower().Where(char.IsLetterOrDigit).ToArray());

            // ── TWO POINTER dengan trace ──
            int left = 0, right = cleaned.Length - 1;
            bool palindrome = true;
            var trace = new List<string>();

            while (left < right)
            {
                char l = cleaned[left], r = cleaned[right];
                if (l != r)
                { trace.Add($"  [{left}]='{l}' ≠ [{right}]='{r}' → BUKAN palindrome!"); palindrome = false; break; }
                else
                { trace.Add($"  [{left}]='{l}' = [{right}]='{r}' ✓"); }
                left++; right--;
            }

            Console.WriteLine();
            TampilkanBox(new[] {
                $"Input    : \"{input}\"",
                $"Cleaned  : \"{cleaned}\"",
                $"Hasil    : {(palindrome ? "PALINDROME ✓" : "BUKAN Palindrome ✗")}",
            }, palindrome ? ConsoleColor.Green : ConsoleColor.Red);

            Warna(ConsoleColor.DarkGray, () => {
                Console.WriteLine("\n  ── Trace Two Pointer ──");
                trace.ForEach(Console.WriteLine);
                if (palindrome) Console.WriteLine("  Semua pasangan cocok → PALINDROME");
            });

            Console.Write("\n  Tekan Enter untuk lanjut...");
            Console.ReadLine();
        }
    }

    // ═════════════════════════════════════════════════════════════
    // SOAL 10: RUN-LENGTH ENCODING
    // ═════════════════════════════════════════════════════════════
    static void Soal10_RLE()
    {
        HeaderSoal("SOAL 10", "Run-Length Encoding (RLE)",
            "Masukkan string. Program kelompokkan karakter berurutan + ordinal.",
            "Contoh: 'aaaabbbcc' → a pertama=4, b pertama=3, c pertama=2");

        string[] ordinals = {"pertama","kedua","ketiga","keempat","kelima",
                             "keenam","ketujuh","kedelapan","kesembilan","kesepuluh"};

        while (true)
        {
            Console.Write("\n  Masukkan string (atau 'x' kembali): ");
            string input = Console.ReadLine();
            if (input?.ToLower() == "x") break;
            if (string.IsNullOrEmpty(input)) { PesanError("String tidak boleh kosong!"); continue; }

            // ── LOGIKA ──
            var occurrenceCount = new Dictionary<char, int>();
            var hasilGrup = new List<Tuple<char, int, string>>();

            int i = 0;
            while (i < input.Length)
            {
                char current = input[i];
                int count = 0;

                // Hitung grup berturut-turut
                while (i < input.Length && input[i] == current)
                { count++; i++; }

                if (!occurrenceCount.ContainsKey(current)) occurrenceCount[current] = 0;
                occurrenceCount[current]++;

                int ordIdx = occurrenceCount[current] - 1;
                string ordinal = ordIdx < ordinals.Length ? ordinals[ordIdx] : $"ke-{occurrenceCount[current]}";
                hasilGrup.Add(Tuple.Create(current, count, ordinal));
            }

            // ── OUTPUT ──
            Console.WriteLine();
            Warna(ConsoleColor.Cyan, () => Console.WriteLine($"  Input  : \"{input}\"\n  Output :"));

            foreach (var grup in hasilGrup)
            {
                char ch = grup.Item1;
                int count = grup.Item2;
                string ord = grup.Item3;
                Console.Write("    ");
                Warna(ConsoleColor.Yellow, () => Console.Write("'" + ch + "'"));
                Console.Write(" " + ord.PadRight(12) + " = ");
                Warna(ConsoleColor.Green, () => Console.WriteLine(count));
            }

            // ── TRACE ──
            Console.WriteLine();
            Warna(ConsoleColor.DarkGray, () => {
                Console.WriteLine("  ── Cara Kerja Loop ──");
                Console.WriteLine("  Outer while: maju per GRUP");
                Console.WriteLine("  Inner while: hitung panjang grup (selama karakter sama)");
                Console.WriteLine("  Dictionary:  lacak sudah berapa kali tiap karakter muncul");
            });

            Console.Write("\n  Tekan Enter untuk lanjut...");
            Console.ReadLine();
        }
    }

    // ═════════════════════════════════════════════════════════════
    // SOAL 11: ANAGRAM
    // ═════════════════════════════════════════════════════════════
    static void Soal11_Anagram()
    {
        HeaderSoal("SOAL 11", "Anagram Checker",
            "Masukkan 2 string. Program cek apakah anagram satu sama lain.",
            "Anagram = huruf yang sama, urutan berbeda. Abaikan spasi & case.");

        while (true)
        {
            Console.Write("\n  String pertama (atau 'x' kembali): ");
            string a = Console.ReadLine();
            if (a?.ToLower() == "x") break;

            Console.Write("  String kedua                     : ");
            string b = Console.ReadLine();

            // ── BERSIHKAN ──
            string ca = new string(a.ToLower().Where(char.IsLetter).ToArray());
            string cb = new string(b.ToLower().Where(char.IsLetter).ToArray());

            // ── LOGIKA FREQUENCY COUNTER ──
            var freq = new Dictionary<char, int>();
            foreach (char c in ca)
            { if (!freq.ContainsKey(c)) freq[c] = 0; freq[c]++; }

            bool anagram = true;
            var trace = new List<string>();

            foreach (char c in cb)
            {
                if (!freq.ContainsKey(c))
                { trace.Add($"  '{c}' tidak ada di string pertama → BUKAN anagram"); anagram = false; break; }
                freq[c]--;
                if (freq[c] < 0)
                { trace.Add($"  '{c}' lebih banyak di string kedua → BUKAN anagram"); anagram = false; break; }
                trace.Add($"  '{c}' ✓ (freq['{c}'] sisa: {freq[c]})");
            }

            if (anagram && ca.Length != cb.Length) anagram = false;

            Console.WriteLine();
            TampilkanBox(new[] {
                $"String 1 : \"{a}\" → cleaned: \"{ca}\"",
                $"String 2 : \"{b}\" → cleaned: \"{cb}\"",
                $"Hasil    : {(anagram ? "ANAGRAM ✓" : "BUKAN Anagram ✗")}",
            }, anagram ? ConsoleColor.Green : ConsoleColor.Red);

            // Frekuensi tiap huruf
            Console.WriteLine();
            Warna(ConsoleColor.DarkGray, () => {
                Console.WriteLine("  ── Frekuensi Huruf ──");
                var allChars = ca.ToHashSet().Union(cb.ToHashSet()).OrderBy(c => c);
                Console.WriteLine($"  {"Huruf",-8} {"String 1",-12} {"String 2",-12} {"Sama?"}");
                foreach (char c in allChars)
                {
                    int f1 = ca.Count(x => x == c);
                    int f2 = cb.Count(x => x == c);
                    Console.WriteLine($"  '{c}'      {f1,-12} {f2,-12} {(f1 == f2 ? "✓" : "✗")}");
                }
                trace.ForEach(Console.WriteLine);
            });

            Console.Write("\n  Tekan Enter untuk lanjut...");
            Console.ReadLine();
        }
    }

    // ═════════════════════════════════════════════════════════════
    // SOAL 12: BANK ACCOUNT
    // ═════════════════════════════════════════════════════════════
    static void Soal12_BankAccount()
    {
        HeaderSoal("SOAL 12", "BankAccount — OOP & Encapsulation",
            "Simulasi rekening bank. Deposit, Withdraw, lihat riwayat.",
            "Saldo tidak bisa diakses/diubah langsung dari luar class.");

        Console.Write("\n  Nama pemilik rekening: ");
        string nama = Console.ReadLine()?.Trim();
        if (string.IsNullOrWhiteSpace(nama)) nama = "User";

        Console.Write("  Saldo awal (angka): ");
        double.TryParse(Console.ReadLine(), out double saldoAwal);

        var akun = new BankAccount(nama, saldoAwal);

        while (true)
        {
            Console.WriteLine();
            Warna(ConsoleColor.Cyan, () => {
                Console.WriteLine($"  ── Rekening: {akun.NamaPemilik} | Saldo: {akun.Saldo:N0} ──");
                Console.WriteLine("  [1] Deposit   [2] Tarik   [3] Riwayat   [0] Kembali");
            });
            Console.Write("  Pilihan: ");
            string p = Console.ReadLine()?.Trim();

            if (p == "0") break;
            if (p == "3") { akun.CetakRiwayat(); Console.Write("\n  Tekan Enter..."); Console.ReadLine(); continue; }
            if (p != "1" && p != "2") { PesanError("Pilih 1, 2, 3, atau 0"); continue; }

            Console.Write(p == "1" ? "  Jumlah deposit : " : "  Jumlah tarik   : ");
            if (!double.TryParse(Console.ReadLine(), out double jumlah))
            { PesanError("Masukkan angka yang valid!"); continue; }

            Console.WriteLine();
            if (p == "1") akun.Deposit(jumlah);
            else akun.Withdraw(jumlah);

            Console.Write("\n  Tekan Enter untuk lanjut...");
            Console.ReadLine();
        }
    }

    // ═════════════════════════════════════════════════════════════
    // SOAL 13: SISTEM NILAI MAHASISWA
    // ═════════════════════════════════════════════════════════════
    static void Soal13_SistemNilai()
    {
        HeaderSoal("SOAL 13", "Sistem Nilai Mahasiswa — OOP + LINQ",
            "Data 8 mahasiswa sudah disiapkan. Pilih query LINQ yang ingin dijalankan.",
            "Lihat cara LINQ memfilter, mengurutkan, dan mengelompokkan data.");

        var mahasiswas = new List<Mahasiswa>
        {
            new Mahasiswa{Nama="Andi",  NIM="001",Nilai=85},
            new Mahasiswa{Nama="Budi",  NIM="002",Nilai=72},
            new Mahasiswa{Nama="Citra", NIM="003",Nilai=91},
            new Mahasiswa{Nama="Deni",  NIM="004",Nilai=65},
            new Mahasiswa{Nama="Eva",   NIM="005",Nilai=78},
            new Mahasiswa{Nama="Fajar", NIM="006",Nilai=55},
            new Mahasiswa{Nama="Gina",  NIM="007",Nilai=88},
            new Mahasiswa{Nama="Hana",  NIM="008",Nilai=69},
        };

        while (true)
        {
            Console.WriteLine();
            Warna(ConsoleColor.Cyan, () => {
                Console.WriteLine("  Pilih Query LINQ:");
                Console.WriteLine("  [1] Tampilkan semua data");
                Console.WriteLine("  [2] Filter: mahasiswa LULUS (nilai >= 70)");
                Console.WriteLine("  [3] Peringkat Top 3");
                Console.WriteLine("  [4] Rata-rata nilai");
                Console.WriteLine("  [5] Distribusi Grade (A/B/C/D/E)");
                Console.WriteLine("  [6] Cari mahasiswa by nama");
                Console.WriteLine("  [0] Kembali");
            });
            Console.Write("  Pilihan: ");
            string p = Console.ReadLine()?.Trim();

            Console.WriteLine();
            switch (p)
            {
                case "0": return;
                case "1":
                    Warna(ConsoleColor.Yellow, () => Console.WriteLine("  LINQ: mahasiswas.OrderByDescending(m => m.Nilai)"));
                    Console.WriteLine();
                    mahasiswas.OrderByDescending(m => m.Nilai).ToList()
                        .ForEach(m => Console.WriteLine($"  {m}"));
                    break;
                case "2":
                    Warna(ConsoleColor.Yellow, () => Console.WriteLine("  LINQ: .Where(m => m.Nilai >= 70).OrderByDescending(m => m.Nilai)"));
                    Console.WriteLine();
                    mahasiswas.Where(m => m.Nilai >= 70).OrderByDescending(m => m.Nilai).ToList()
                        .ForEach(m => Console.WriteLine($"  {m}"));
                    break;
                case "3":
                    Warna(ConsoleColor.Yellow, () => Console.WriteLine("  LINQ: .OrderByDescending(m => m.Nilai).Take(3)"));
                    Console.WriteLine();
                    var top3 = mahasiswas.OrderByDescending(m => m.Nilai).Take(3).ToList();
                    for (int i = 0; i < top3.Count; i++)
                        Console.WriteLine($"  Peringkat {i + 1}: {top3[i].Nama} — {top3[i].Nilai} ({top3[i].Grade})");
                    break;
                case "4":
                    double avg = mahasiswas.Average(m => m.Nilai);
                    Warna(ConsoleColor.Yellow, () => Console.WriteLine("  LINQ: .Average(m => m.Nilai)"));
                    Console.WriteLine($"\n  Rata-rata nilai: {avg:F2}");
                    Console.WriteLine($"  Di atas rata-rata: {mahasiswas.Count(m => m.Nilai >= avg)} mahasiswa");
                    Console.WriteLine($"  Di bawah rata-rata: {mahasiswas.Count(m => m.Nilai < avg)} mahasiswa");
                    break;
                case "5":
                    Warna(ConsoleColor.Yellow, () => Console.WriteLine("  LINQ: .GroupBy(m => m.Grade).OrderBy(g => g.Key)"));
                    Console.WriteLine();
                    mahasiswas.GroupBy(m => m.Grade).OrderBy(g => g.Key).ToList()
                        .ForEach(g => {
                            Console.Write($"  Grade {g.Key} ({g.Count()}): ");
                            Console.WriteLine(string.Join(", ", g.Select(m => m.Nama)));
                        });
                    break;
                case "6":
                    Console.Write("  Cari nama: ");
                    string cari = Console.ReadLine()?.ToLower();
                    var found = mahasiswas.Where(m => m.Nama.ToLower().Contains(cari)).ToList();
                    if (!found.Any()) PesanError("Tidak ditemukan!");
                    else found.ForEach(m => Console.WriteLine($"  {m}"));
                    break;
                default: PesanTidakValid(); continue;
            }

            Console.Write("\n  Tekan Enter untuk lanjut...");
            Console.ReadLine();
        }
    }

    // ═════════════════════════════════════════════════════════════
    // SOAL 14: VALID PARENTHESES
    // ═════════════════════════════════════════════════════════════
    static void Soal14_ValidParentheses()
    {
        HeaderSoal("SOAL 14", "Valid Parentheses — Stack Pattern",
            "Masukkan string berisi kurung. Program cek apakah VALID.",
            "Visualisasi stack push/pop ditampilkan step by step.");

        while (true)
        {
            Console.Write("\n  Masukkan string (contoh: ([{}]), atau 'x' kembali): ");
            string input = Console.ReadLine();
            if (input?.ToLower() == "x") break;

            // ── LOGIKA DENGAN VISUALISASI STACK ──
            var stack = new Stack<char>();
            var trace = new List<Tuple<string, char, string, bool>>();
            bool valid = true;

            foreach (char c in input)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    stack.Push(c);
                    trace.Add(Tuple.Create($"PUSH '{c}'", c, "[" + string.Join(",", stack.Reverse()) + "]", true));
                }
                else if (c == ')' || c == ']' || c == '}')
                {
                    if (stack.Count == 0)
                    { trace.Add(Tuple.Create($"POP  '{c}' — STACK KOSONG!", c, "[]", false)); valid = false; break; }

                    char top = stack.Pop();
                    bool match = (c == ')' && top == '(') || (c == ']' && top == '[') || (c == '}' && top == '{');
                    trace.Add(Tuple.Create($"POP  '{c}' > '{top}' {(match ? "OK" : "TIDAK COCOK!")}", c,
                               "[" + string.Join(",", stack.Reverse()) + "]", match));
                    if (!match) { valid = false; break; }
                }
            }
            if (valid && stack.Count > 0)
            { trace.Add(Tuple.Create($"Akhir: stack masih berisi {stack.Count} item!", ' ', "[" + string.Join(",", stack.Reverse()) + "]", false)); valid = false; }

            Console.WriteLine();
            TampilkanBox(new[] {
                $"Input  : \"{input}\"",
                $"Hasil  : {(valid ? "VALID ✓" : "TIDAK VALID ✗")}",
            }, valid ? ConsoleColor.Green : ConsoleColor.Red);

            Console.WriteLine();
            Warna(ConsoleColor.DarkGray, () => {
                Console.WriteLine($"  {"Operasi",-30} {"Stack State"}");
                Console.WriteLine($"  {new string('-', 50)}");
                foreach (var t in trace)
                {
                    string op = t.Item1; string state = t.Item3; bool ok = t.Item4;
                    Console.Write("  " + op.PadRight(30) + " " + state);
                    if (!ok) Warna(ConsoleColor.Red, () => Console.Write(" <- ERROR"));
                    Console.WriteLine();
                }
            });

            Console.Write("\n  Tekan Enter untuk lanjut...");
            Console.ReadLine();
        }
    }

    // ═════════════════════════════════════════════════════════════
    // SOAL 15: DATA TRANSAKSI
    // ═════════════════════════════════════════════════════════════
    static void Soal15_DataTransaksi()
    {
        HeaderSoal("SOAL 15", "Data Transaksi — GroupBy & Sort",
            "Data transaksi sudah disiapkan. Program kelompokkan per customer.",
            "Urutkan: jumlah transaksi terbanyak dulu, jika sama → ID terkecil.");

        var data = new List<(string id, double amount, string date)>
        {
            ("C15",150000,"2024-01-05"),("C21",200000,"2024-01-07"),
            ("C15",75000, "2024-01-09"),("C20",300000,"2024-01-10"),
            ("C15",50000, "2024-01-12"),("C20",125000,"2024-01-15"),
            ("C16",90000, "2024-01-18"),("C20",80000, "2024-01-20"),
        };

        // Tampilkan raw data dulu
        Console.WriteLine();
        Warna(ConsoleColor.DarkGray, () => {
            Console.WriteLine("  ── Data Mentah ──");
            Console.WriteLine($"  {"CustomerID",-12}{"Amount",12}  {"Date"}");
            Console.WriteLine($"  {new string('-', 40)}");
            data.ForEach(d => Console.WriteLine($"  {d.id,-12}{d.amount,12:N0}  {d.date}"));
        });

        // ── LOGIKA ──
        var hasil = data
            .GroupBy(d => d.id)
            .Select(g => new {
                CustomerID = g.Key,
                Jumlah = g.Count(),
                Total = g.Sum(d => d.amount)
            })
            .OrderByDescending(x => x.Jumlah)
            .ThenBy(x => x.CustomerID)
            .ToList();

        Console.WriteLine();
        Warna(ConsoleColor.Cyan, () => {
            Console.WriteLine($"\n  ── Hasil GroupBy + Sort ──");
            Console.WriteLine($"  {"CustomerID",-14}{"Jumlah Transaksi",-20}{"Total Amount"}");
            Console.WriteLine($"  {new string('─', 50)}");
        });

        foreach (var r in hasil)
        {
            ConsoleColor warna = r.Jumlah == hasil[0].Jumlah ? ConsoleColor.Green : ConsoleColor.Gray;
            Warna(warna, () =>
                Console.WriteLine($"  {r.CustomerID,-14}{r.Jumlah,-20}{r.Total:N0}"));
        }

        TampilkanPenjelasan(new[] {
            "LINQ chain: .GroupBy(id) → .Select(hitung) → .OrderByDescending(jumlah) → .ThenBy(id)",
            "ThenBy: tiebreaker — jika jumlah sama, urutkan CustomerID secara ascending",
            "Select anonymous type: { CustomerID, Jumlah, Total } → object sementara untuk query",
        });

        Console.Write("\n  Tekan Enter untuk kembali ke menu...");
        Console.ReadLine();
    }

    // ═════════════════════════════════════════════════════════════
    // SOAL 16: FILTER SORT ARRAY (Soal Interview Kemarin!)
    // ═════════════════════════════════════════════════════════════
    static void Soal16_FilterSortArray()
    {
        HeaderSoal("SOAL 16", "Filter & Sort Array — Pola Coding Test Nyata",
            "PERSIS soal yang gagal kemarin! Masukkan array angka.",
            "Program tampilkan output dengan pola: ganjil turun-2 + max ganjil.");

        while (true)
        {
            Console.Write("\n  Masukkan array (pisah koma, atau 'x' kembali): ");
            string raw = Console.ReadLine()?.Trim();
            if (raw?.ToLower() == "x") break;

            int[] input = ParseArrayInt(raw);
            if (input == null) continue;

            // ── ANALISIS POLA ──
            var ganjil = input.Where(x => x % 2 != 0).ToList();

            if (!ganjil.Any())
            { PesanError("Tidak ada bilangan ganjil dalam array!"); continue; }

            int maxGanjil = ganjil.Max();
            var result = new List<int>();
            int prev = ganjil[0];
            result.Add(prev);

            var trace = new List<string>();
            trace.Add($"  Mulai: ambil ganjil pertama = {prev}");

            for (int i = 1; i < ganjil.Count; i++)
            {
                bool turunDua = ganjil[i] - prev == -2;
                bool isMax = ganjil[i] == maxGanjil && !result.Contains(maxGanjil);

                if (turunDua)
                {
                    trace.Add($"  ganjil[{i}]={ganjil[i]}: {ganjil[i]}-{prev}=-2 ✓ TURUN DUA → masuk");
                    result.Add(ganjil[i]);
                    prev = ganjil[i];
                }
                else if (isMax)
                {
                    trace.Add($"  ganjil[{i}]={ganjil[i]}: adalah MAX GANJIL ({maxGanjil}) → masuk");
                    result.Add(ganjil[i]);
                }
                else
                {
                    trace.Add($"  ganjil[{i}]={ganjil[i]}: diff={ganjil[i] - prev} (bukan -2), bukan max → SKIP");
                }
            }

            result = result.OrderByDescending(x => x).ToList();

            Console.WriteLine();
            TampilkanBox(new[] {
                $"Input    : [{string.Join(", ", input)}]",
                $"Ganjil   : [{string.Join(", ", ganjil)}]",
                $"Max Ganjil: {maxGanjil}",
                $"Output   : [{string.Join(", ", result)}]",
            }, ConsoleColor.Green);

            Warna(ConsoleColor.DarkGray, () => {
                Console.WriteLine("\n  ── Trace Analisis Pola ──");
                trace.ForEach(Console.WriteLine);
                Console.WriteLine($"\n  Hasil sort descending: [{string.Join(", ", result)}]");
            });

            Console.Write("\n  Tekan Enter untuk lanjut...");
            Console.ReadLine();
        }
    }

    // ═════════════════════════════════════════════════════════════
    // HELPER CLASSES
    // ═════════════════════════════════════════════════════════════

    class BankAccount
    {
        private double _saldo;
        private string _nama;
        private List<string> _riwayat = new List<string>();

        public string NamaPemilik => _nama;
        public double Saldo => _saldo;

        public BankAccount(string nama, double saldoAwal)
        {
            if (saldoAwal < 0) { PesanError("Saldo awal tidak boleh negatif!"); saldoAwal = 0; }
            _nama = nama;
            _saldo = saldoAwal;
            _riwayat.Add($"[BUKA] Saldo awal: {saldoAwal:N0}");
            Warna(ConsoleColor.Green, () =>
                Console.WriteLine($"\n  Rekening '{nama}' dibuka. Saldo awal: {saldoAwal:N0}"));
        }

        public void Deposit(double jumlah)
        {
            if (jumlah <= 0) { PesanError("Deposit harus lebih dari 0!"); return; }
            _saldo += jumlah;
            _riwayat.Add($"[+] Deposit {jumlah:N0} → saldo: {_saldo:N0}");
            Warna(ConsoleColor.Green, () =>
                Console.WriteLine($"  Deposit {jumlah:N0} berhasil. Saldo: {_saldo:N0}"));
        }

        public void Withdraw(double jumlah)
        {
            if (jumlah <= 0) { PesanError("Jumlah tarik harus lebih dari 0!"); return; }
            if (jumlah > _saldo) { PesanError($"Saldo tidak cukup! Saldo: {_saldo:N0}, Diminta: {jumlah:N0}"); return; }
            _saldo -= jumlah;
            _riwayat.Add($"[-] Tarik {jumlah:N0} → saldo: {_saldo:N0}");
            Warna(ConsoleColor.Cyan, () =>
                Console.WriteLine($"  Tarik {jumlah:N0} berhasil. Saldo: {_saldo:N0}"));
        }

        public void CetakRiwayat()
        {
            Console.WriteLine();
            Warna(ConsoleColor.Cyan, () =>
                Console.WriteLine($"  ═══ Riwayat: {_nama} ═══"));
            _riwayat.ForEach(r => Console.WriteLine("  " + r));
            Warna(ConsoleColor.Green, () =>
                Console.WriteLine($"  Saldo Akhir: {_saldo:N0}"));
        }
    }

    class Mahasiswa
    {
        public string Nama { get; set; }
        public string NIM { get; set; }
        public double Nilai { get; set; }
        public string Grade => Nilai >= 85 ? "A" : Nilai >= 75 ? "B" : Nilai >= 65 ? "C" : Nilai >= 55 ? "D" : "E";
        public string Status => Nilai >= 70 ? "LULUS" : "GAGAL";
        public override string ToString()
            => $"  {NIM} | {Nama,-10} | Nilai: {Nilai:F0} | Grade: {Grade} | {Status}";
    }

    // ═════════════════════════════════════════════════════════════
    // UI HELPERS
    // ═════════════════════════════════════════════════════════════

    static void Warna(ConsoleColor c, Action a)
    { Console.ForegroundColor = c; a(); Console.ResetColor(); }

    static void MenuItem(string key, string tag, string desc)
    {
        Console.Write("  ");
        Warna(ConsoleColor.Yellow, () => Console.Write($"[{key}]"));
        Console.Write(" ");
        Warna(ConsoleColor.Cyan, () => Console.Write($"{tag,-10}"));
        Console.Write(" — ");
        Console.WriteLine(desc);
    }

    static void HeaderBagian(string judul, ConsoleColor warna)
    {
        Console.Clear();
        Warna(warna, () => {
            string garis = new string('═', judul.Length + 4);
            Console.WriteLine($"\n  ╔{garis}╗");
            Console.WriteLine($"  ║  {judul}  ║");
            Console.WriteLine($"  ╚{garis}╝\n");
        });
    }

    static void HeaderSoal(string no, string judul, string deskripsi, string pola)
    {
        Console.Clear();
        Warna(ConsoleColor.Cyan, () => Console.WriteLine($"\n  ┌─ {no}: {judul}"));
        Console.WriteLine($"  │  {deskripsi}");
        Warna(ConsoleColor.DarkYellow, () => Console.WriteLine($"  │  Pola: {pola}"));
        Console.WriteLine("  └" + new string('─', 60));
        Console.WriteLine("  (Ketik 'x' kapan saja untuk kembali ke menu)\n");
    }

    static void TampilkanBox(string[] lines, ConsoleColor warna)
    {
        int w = lines.Max(l => l.Length) + 4;
        Warna(warna, () => {
            Console.WriteLine($"  ╔{new string('═', w)}╗");
            foreach (var l in lines)
                Console.WriteLine($"  ║  {l.PadRight(w - 2)}║");
            Console.WriteLine($"  ╚{new string('═', w)}╝");
        });
    }

    static void TampilkanPenjelasan(string[] lines)
    {
        Console.WriteLine();
        Warna(ConsoleColor.DarkGray, () => {
            Console.WriteLine("  ── Penjelasan ──");
            foreach (var l in lines)
                Console.WriteLine($"  • {l}");
        });
    }

    static void PesanError(string msg)
    { Warna(ConsoleColor.Red, () => Console.WriteLine($"\n  ✗ {msg}\n")); }

    static void PesanTidakValid()
    { Warna(ConsoleColor.Red, () => Console.WriteLine("\n  Pilihan tidak valid!\n")); }

    static void Keluar()
    {
        Console.Clear();
        Warna(ConsoleColor.Green, () => {
            Console.WriteLine("\n  ╔══════════════════════════════════╗");
            Console.WriteLine("  ║  Sampai jumpa! Terus berlatih!  ║");
            Console.WriteLine("  ║  Konsistensi mengalahkan bakat. ║");
            Console.WriteLine("  ╚══════════════════════════════════╝\n");
        });
    }

    static double BacaDouble(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            if (double.TryParse(Console.ReadLine(), out double val)) return val;
            PesanError("Masukkan angka yang valid!");
        }
    }

    static int[] ParseArrayInt(string input)
    {
        try
        {
            var arr = input.Split(',').Select(s => int.Parse(s.Trim())).ToArray();
            if (arr.Length == 0) throw new Exception();
            return arr;
        }
        catch
        {
            PesanError("Format salah! Contoh: 5,3,8,1,9 (angka dipisah koma)");
            return null;
        }
    }
}