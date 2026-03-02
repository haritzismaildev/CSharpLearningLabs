# 💻 C# Learning Lab — Interactive Console Exercises

<div align="center">

![C#](https://img.shields.io/badge/C%23-10.0+-239120?style=for-the-badge&logo=csharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-6.0+-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![Platform](https://img.shields.io/badge/Platform-Windows%20%7C%20Linux%20%7C%20macOS-blue?style=for-the-badge)
![License](https://img.shields.io/badge/License-MIT-green?style=for-the-badge)
![Status](https://img.shields.io/badge/Status-Active-brightgreen?style=for-the-badge)

**Aplikasi console interaktif untuk belajar C# dari fondasi hingga siap coding test.**
Setiap soal bisa diuji dengan input kamu sendiri. Setiap algoritma divisualisasikan langkah per langkah.

[Cara Menjalankan](#-cara-menjalankan) · [Daftar Soal](#-daftar-soal-lengkap) · [Detail Soal](#-detail-setiap-soal) · [Roadmap](#-roadmap)

</div>

---

## 📋 Daftar Isi

- [Tentang Project](#-tentang-project)
- [Mengapa Aplikasi Ini Beda](#-mengapa-aplikasi-ini-beda)
- [Fitur Utama](#-fitur-utama)
- [Struktur Menu](#-struktur-menu)
- [Daftar Soal Lengkap](#-daftar-soal-lengkap)
- [Detail Setiap Soal](#-detail-setiap-soal)
- [Cara Menjalankan](#-cara-menjalankan)
- [Struktur Project](#-struktur-project)
- [Teknologi & Dependencies](#-teknologi--dependencies)
- [Konsep yang Dipelajari](#-konsep-yang-dipelajari)
- [Contoh Output](#-contoh-output)
- [Roadmap](#-roadmap)
- [FAQ](#-faq)
- [Kontribusi](#-kontribusi)
- [Lisensi](#-lisensi)

---

## 🎯 Tentang Project

**C# Learning Lab** adalah aplikasi console interaktif satu file yang menyatukan **16 soal latihan pemrograman C#** dalam satu menu terpadu. Setiap soal bisa langsung dijalankan, diuji dengan input apapun, dan melihat cara kerja algoritmanya secara transparan.

Project ini lahir dari kebutuhan nyata: belajar bukan hanya membaca teori, tapi **merasakan langsung bagaimana logika berjalan**. Tidak perlu buka IDE untuk setiap soal, tidak perlu ganti file, tidak perlu restart — cukup pilih nomor dari menu.

### Target Pengguna

| Profil | Manfaat |
|---|---|
| Pemula yang sudah tahu syntax tapi bingung logika | Lihat trace step-by-step untuk memahami cara algoritma bekerja |
| Developer yang mempersiapkan diri untuk coding test | 16 soal dengan tipe dan pola yang muncul di interview nyata |
| Pelajar yang ingin membangun portofolio GitHub | Repo ini sendiri adalah bukti kemampuan yang bisa ditunjukkan ke rekruter |

---

## 🔍 Mengapa Aplikasi Ini Beda

Kebanyakan tutorial C# hanya menampilkan kode yang langsung jalan tanpa penjelasan *kenapa*. Di sini setiap soal dirancang dengan tiga lapisan:

```
┌─────────────────────────────────────────────────────┐
│  LAPISAN 1: Input dari kamu sendiri                 │
│  → Bukan data hardcode. Masukkan angka/kata apapun. │
├─────────────────────────────────────────────────────┤
│  LAPISAN 2: Hasil yang benar                        │
│  → Output yang tepat dan terformat rapi             │
├─────────────────────────────────────────────────────┤
│  LAPISAN 3: Trace cara kerjanya                     │
│  → Setiap langkah algoritma ditampilkan eksplisit.  │
│  → Lihat KENAPA hasilnya begitu, bukan hanya APA.   │
└─────────────────────────────────────────────────────┘
```

---

## ✨ Fitur Utama

### 🎮 Menu Interaktif Bertingkat
Navigasi dari menu utama → sub-menu bagian → eksekusi soal → kembali, tanpa pernah perlu restart program.

### 🔁 Input Berulang Tanpa Batas
Setiap soal bisa diuji berkali-kali dengan input berbeda dalam satu sesi. Coba `3,5,8,6,1,4,2,7,9` lalu langsung coba `10,20,30` — tanpa loading.

### 🔍 Visualisasi Step-by-Step
Bukan hanya hasilnya — **proses mencapai hasil** itu yang ditampilkan:
- Two pointer → tampilkan posisi `left` dan `right` setiap iterasi + state array setelah swap
- Stack → tampilkan `PUSH`/`POP` dan isi stack setiap karakter diproses
- Dictionary → tampilkan isi `seen[]` setiap langkah pencarian
- Loop → tampilkan kapan nilai di-update dan kapan di-skip beserta alasannya

### ⚖️ Perbandingan Algoritma Langsung
Soal Two Sum menampilkan **dua pendekatan sekaligus** dari input yang sama — O(n²) naif dan O(n) optimal — dengan hitungan iterasi aktual yang bisa kamu bandingkan.

### 🎨 Output Berwarna Konsisten

| Warna | Digunakan untuk |
|---|---|
| 🔵 Cyan | Header soal, struktur menu, info umum |
| 🟢 Hijau | Hasil benar, sukses, nilai yang match |
| 🔴 Merah | Error, tidak valid, nilai yang tidak match |
| 🟡 Kuning | Highlight nilai penting, pilihan menu |
| ⬜ Abu-abu | Trace internal, penjelasan tambahan |
| 🟣 Magenta | Label ganjil pada FizzBuzz, header OOP |

### 🛡️ Validasi Input Robust
Semua input divalidasi sebelum diproses — input non-angka tidak membuat program crash, format array salah langsung diberi instruksi, operasi ilegal (bagi 0, saldo kurang) ditolak dengan penjelasan spesifik.

---

## 🗂️ Struktur Menu

```
╔══════════════════════════════════════════════════════════╗
║          C# LEARNING LAB — Interactive Exercises         ║
╚══════════════════════════════════════════════════════════╝
│
├── [1] Bagian 1 — Logika & Kondisi Dasar          (4 soal)
│       ├── [1] Soal 01 · Cek Ganjil atau Genap
│       ├── [2] Soal 02 · FizzBuzz (1 sampai N)
│       ├── [3] Soal 03 · Cek Tahun Kabisat
│       └── [4] Soal 04 · Kalkulator Interaktif
│
├── [2] Bagian 2 — Array & Manipulasi Data         (4 soal)
│       ├── [1] Soal 05 · Max, Min & Rata-rata Array
│       ├── [2] Soal 06 · Balik Urutan Array (Two Pointer)
│       ├── [3] Soal 07 · Hapus Duplikat dari Array
│       └── [4] Soal 08 · Two Sum — Cari Pasangan Target
│
├── [3] Bagian 3 — String Manipulation             (3 soal)
│       ├── [1] Soal 09 · Cek Palindrome
│       ├── [2] Soal 10 · Run-Length Encoding
│       └── [3] Soal 11 · Anagram Checker
│
├── [4] Bagian 4 — OOP: Dunia Nyata                (2 soal)
│       ├── [1] Soal 12 · BankAccount — Encapsulation & Validasi
│       └── [2] Soal 13 · Sistem Nilai Mahasiswa — OOP + LINQ
│
└── [5] Bagian 5 — Simulasi Coding Test Nyata      (3 soal)
        ├── [1] Soal 14 · Valid Parentheses — Stack Pattern
        ├── [2] Soal 15 · Data Transaksi — GroupBy & Sort
        └── [3] Soal 16 · Filter & Sort Array dengan Pola
```

---

## 📖 Daftar Soal Lengkap

| # | Soal | Konsep Utama | Pola Algoritma | Tingkat |
|---|---|---|---|---|
| 01 | Ganjil atau Genap | `if-else`, operator `%` | Modulo check | 🟢 Easy |
| 02 | FizzBuzz | `for` loop, `if-else if` | Multiple condition ordering | 🟢 Easy |
| 03 | Tahun Kabisat | Kondisi berantai | Rule priority chain | 🟢 Easy |
| 04 | Kalkulator Interaktif | `switch`, `while`, `TryParse` | Input validation loop | 🟢 Easy |
| 05 | Max, Min & Rata-rata | Array traversal, `double` | Linear scan with tracking | 🟢 Easy |
| 06 | Reverse Array | Two pointer, swap | In-place reversal | 🟢 Easy |
| 07 | Hapus Duplikat | `HashSet<T>`, two pointer | Two approaches comparison | 🟡 Medium |
| 08 | Two Sum | `Dictionary<K,V>`, nested loop | Complement lookup | 🟡 Medium |
| 09 | Palindrome | Two pointer, `char` operations | Cleaned string comparison | 🟢 Easy |
| 10 | Run-Length Encoding | While-in-while, `Dictionary` | Group counting + ordinal | 🟡 Medium |
| 11 | Anagram Checker | Frequency counter, `Dictionary` | Character frequency map | 🟡 Medium |
| 12 | BankAccount OOP | Class, encapsulation, `private` | Object state management | 🟡 Medium |
| 13 | Sistem Nilai + LINQ | OOP, `List<T>`, LINQ chain | Data query pipeline | 🟡 Medium |
| 14 | Valid Parentheses | `Stack<char>`, push/pop | Stack bracket matching | 🟡 Medium |
| 15 | Data Transaksi | `GroupBy`, `ThenBy`, anonymous type | Multi-key sort pipeline | 🟡 Medium |
| 16 | Filter Sort Array | Pattern analysis, LINQ | Rule-based filtering | 🔴 Hard |

---

## 📚 Detail Setiap Soal

---

### 🟢 BAGIAN 1 — Logika & Kondisi Dasar

Fondasi yang harus solid sebelum masuk ke topik lain. Setiap soal melatih **cara berpikir kondisional** yang menjadi tulang punggung semua program.

---

#### `Soal 01` — Ganjil atau Genap

**Konsep:** Operator modulo `%`, kondisi `if-else`, string interpolation  
**Input:** Satu angka bulat sembarang dari user  
**Output:** Label GANJIL atau GENAP, plus nilai sisa pembagian  
**Trace yang ditampilkan:**
```
Langkah 1 → Hitung sisa bagi 2 : 42 % 2 = 0
Langkah 2 → Jika sisa = 0 → GENAP, jika sisa = 1 → GANJIL
Kesimpulan → 42 % 2 = 0 → GENAP
```
**Mengapa penting:** Operator `%` adalah building block soal filter — bilangan prima, kelipatan N, soal RLE, dan banyak lagi. Harus dipahami dengan benar dari sini.

---

#### `Soal 02` — FizzBuzz

**Konsep:** `for` loop, `if-else if-else`, multiple modulo conditions  
**Input:** Angka N sebagai batas atas  
**Output:** Angka 1 sampai N — `Fizz` (hijau), `Buzz` (kuning), `FizzBuzz` (magenta), angka biasa (putih)  
**Bonus:** Statistik jumlah Fizz, Buzz, FizzBuzz, dan angka biasa dari 1 sampai N

> ⚠️ **Hal kritis:** `FizzBuzz` (kelipatan 3 DAN 5) **harus dicek pertama**. Jika Fizz dicek duluan, angka 15 akan masuk sebagai Fizz saja — hasil yang salah.

**Relevansi interview:** Soal ini hadir di screening tahap pertama hampir semua perusahaan tech. Terlihat trivial, tapi banyak kandidat yang gagal karena urutan kondisi keliru.

---

#### `Soal 03` — Cek Tahun Kabisat

**Konsep:** Kondisi berantai `if-else if`, logika bertingkat, return early pattern  
**Input:** Satu angka tahun  
**Output:** Status kabisat atau bukan + aturan mana yang berlaku  

| Prioritas | Kondisi | Hasil |
|---|---|---|
| 1 (tertinggi) | `tahun % 400 == 0` | KABISAT |
| 2 | `tahun % 100 == 0` (dan bukan 400) | BUKAN kabisat |
| 3 | `tahun % 4 == 0` (dan bukan 100) | KABISAT |
| 4 (default) | Selain itu | BUKAN kabisat |

**Trace yang ditampilkan:**
```
2000: 2000 % 400 = 0 → KABISAT (aturan 1)

1900: 1900 % 400 = 300 (bukan 0)
      1900 % 100 = 0   → BUKAN kabisat (aturan 2)
```

---

#### `Soal 04` — Kalkulator Interaktif

**Konsep:** `switch-case`, `while(true)` dengan `break`, `double.TryParse()`, validasi input  
**Input:** Pilih operasi dari menu (1–5), lalu masukkan dua angka  
**Operasi:** `+`, `-`, `*`, `/`, `%`  
**Validasi yang diimplementasikan:**
- Input non-angka → `TryParse` mengembalikan `false`, program meminta ulang tanpa crash
- Bagi atau modulo dengan 0 → ditolak, pesan error spesifik
- Pilihan menu di luar range → pesan tidak valid, kembali ke menu

**Pola yang diajarkan:**
```csharp
// TryParse: AMAN untuk input user
if (double.TryParse(input, out double nilai)) return nilai;
// Parse: BERBAHAYA jika input bukan angka — langsung throw exception
double nilai = double.Parse("abc"); // crash!
```

---

### 🟢 BAGIAN 2 — Array & Manipulasi Data

Array adalah struktur data paling fundamental. Kuasai bagian ini dan lebih dari separuh soal coding test level junior akan terasa familiar.

---

#### `Soal 05` — Max, Min & Rata-rata

**Konsep:** Array traversal, logika update kondisional, casting ke `double`  
**Input:** Array angka dipisah koma — contoh: `5,3,8,1,9,2,7,4,6`  
**Output:** Nilai max, min, total, dan rata-rata 2 desimal  
**Catatan penting:** `Array.Max()`, `Array.Min()`, dan LINQ sengaja tidak digunakan agar logika manual benar-benar dipahami

**Trace yang ditampilkan:**
```
── Trace Pencarian Max ──
Mulai: asumsi max = arr[0] = 5
  arr[2]=8 > max=5 → update max=8
  arr[4]=9 > max=8 → update max=9
Max akhir = 9
```

---

#### `Soal 06` — Reverse Array (Two Pointer)

**Konsep:** Two pointer pattern, in-place swap, variabel sementara `temp`  
**Input:** Array angka dipisah koma  
**Output:** Array yang sudah dibalik urutannya  
**Visualisasi setiap step:**
```
Sebelum: [1, 2, 3, 4, 5]

Step 1: SWAP arr[0]=1 ↔ arr[4]=5
        Array: [5, 2, 3, 4, 1]
Step 2: SWAP arr[1]=2 ↔ arr[3]=4
        Array: [5, 4, 3, 2, 1]

Sesudah: [5, 4, 3, 2, 1]
```
**Trade-off yang diajarkan:** Two pointer = O(1) space (in-place). Membuat array baru dari belakang = O(n) space extra. Perbedaan ini penting diketahui di interview.

---

#### `Soal 07` — Hapus Duplikat

**Konsep:** `HashSet<T>`, two pointer pada sorted array, trade-off perbandingan  
**Input:** Array angka sembarang (urutan bebas, duplikat bebas)  
**Output:** Dua versi hasil secara bersamaan + trace masing-masing

| | Versi A — HashSet | Versi B — Two Pointer |
|---|---|---|
| **Persyaratan** | Array bebas | Array HARUS sorted |
| **Time** | O(n) | O(n) |
| **Space** | O(n) | O(1) |
| **Cara kerja** | `seen.Add(x)` → `false` jika duplikat | Bandingkan `arr[i]` vs `arr[i-1]` |

---

#### `Soal 08` — Two Sum

**Konsep:** Nested loop O(n²), `Dictionary<int,int>`, complement lookup pattern  
**Input:** Array angka dipisah koma + satu angka target  
**Output:** Index dua elemen yang jumlahnya = target, dari dua pendekatan sekaligus

**Pendekatan Optimal O(n):**
```
Untuk setiap elemen x:
  complement = target - x
  Apakah complement sudah ada di Dictionary?
    YA  → pasangan ketemu, return index keduanya
    TIDAK → simpan x ke Dictionary: dict[x] = index
```

**Output yang ditampilkan:**
```
Naif  O(n²): index [0,1] → 2+7=9  (4 iterasi)
Optimal O(n): index [0,1] → 2+7=9  (2 iterasi)
```

> 💡 Two Sum adalah soal paling sering muncul di interview Google, Meta, Amazon, dan hampir semua perusahaan tech besar.

---

### 🟡 BAGIAN 3 — String Manipulation

String adalah tipe data paling sering diuji di coding test. Menguasai pola-pola di bagian ini berarti siap menghadapi mayoritas soal screening tahap awal.

---

#### `Soal 09` — Cek Palindrome

**Konsep:** Two pointer pada string, `char.IsLetterOrDigit()`, `.ToLower()`, `.Where()`  
**Input:** Kata atau kalimat bebas (spasi, tanda baca, dan huruf kapital diabaikan)  
**Output:** PALINDROME atau BUKAN + trace setiap pasangan karakter

| Input | Hasil |
|---|---|
| `"racecar"` | PALINDROME ✓ |
| `"A man a plan a canal Panama"` | PALINDROME ✓ |
| `"Was it a car or a cat I saw"` | PALINDROME ✓ |
| `"hello"` | BUKAN Palindrome ✗ |

---

#### `Soal 10` — Run-Length Encoding (RLE)

**Konsep:** While-dalam-while, `Dictionary<char,int>` untuk ordinal tracking, grup berturut-turut  
**Input:** String berisi karakter berulang  
**Output:** Setiap kelompok karakter dengan keterangan urutan kemunculan

```
Input  : aaaabbbccaabcccccc
Output :
  'a' pertama      = 4
  'b' pertama      = 3
  'c' pertama      = 2
  'a' kedua        = 2
  'b' kedua        = 1
  'c' kedua        = 6
```

**Struktur algoritma:**
```
outer while (i < input.Length):        // maju per GRUP
    current = input[i], count = 0
    inner while (input[i] == current): // hitung panjang grup
        count++, i++
    // satu grup selesai
    update occurrenceCount[current]++
    tentukan ordinal: pertama/kedua/ketiga/...
    print hasil
```

> ⚡ Tipe soal ini muncul di screening test perusahaan lokal, startup regional, dan beberapa perusahaan Timur Tengah sebagai soal wajib.

---

#### `Soal 11` — Anagram Checker

**Konsep:** Frequency counter pattern, `Dictionary<char,int>`, `.Where()`, `.Select()`  
**Input:** Dua string sembarang  
**Output:** ANAGRAM atau BUKAN + tabel frekuensi tiap huruf dari kedua string secara berdampingan

**Tabel yang ditampilkan:**
```
Huruf    String 1     String 2     Sama?
'e'      1            1            ✓
'i'      1            1            ✓
'l'      1            1            ✓
'n'      1            1            ✓
's'      1            1            ✓
't'      1            1            ✓
```

---

### 🟡 BAGIAN 4 — OOP: Dunia Nyata

OOP bukan soal syntax `class` — ini tentang cara memodelkan masalah dunia nyata. Dua soal ini memperlihatkan prinsip OOP yang benar-benar dipakai di production code.

---

#### `Soal 12` — BankAccount — Encapsulation & Validasi

**Konsep:** `class`, `private` field, `public` property read-only, constructor, validasi dalam method  
**Simulasi:** Rekening bank interaktif — buat rekening, deposit, tarik, cetak riwayat  

**Prinsip encapsulation yang didemonstrasikan:**
```csharp
class BankAccount
{
    private double _saldo;           // TIDAK BISA diakses dari luar
    public  double Saldo => _saldo;  // Bisa DIBACA, tidak bisa diset dari luar

    public void Deposit(double jumlah)  { /* satu-satunya cara tambah saldo */ }
    public void Withdraw(double jumlah) { /* satu-satunya cara kurangi saldo */ }
}

// Di luar class:
akun._saldo  = 99999; // COMPILE ERROR
akun.Saldo   = 99999; // COMPILE ERROR — read-only
akun.Deposit(99999);  // OK — melalui method resmi
```

**Validasi yang diimplementasikan:**
- Saldo awal tidak boleh negatif
- Jumlah deposit/withdraw harus positif
- Withdraw ditolak jika saldo tidak mencukupi — dengan pesan yang menampilkan saldo saat ini vs jumlah yang diminta

---

#### `Soal 13` — Sistem Nilai Mahasiswa — OOP + LINQ

**Konsep:** Class dengan computed property, `List<T>`, LINQ method chaining  
**Data:** 8 mahasiswa pre-loaded (Andi 85, Budi 72, Citra 91, Deni 65, Eva 78, Fajar 55, Gina 88, Hana 69)  
**6 Query LINQ tersedia dari menu:**

| Pilihan | Query | LINQ yang Dipakai |
|---|---|---|
| 1 | Tampilkan semua, tertinggi duluan | `.OrderByDescending(m => m.Nilai)` |
| 2 | Filter hanya yang lulus (nilai ≥ 70) | `.Where(m => m.Nilai >= 70).OrderByDescending(...)` |
| 3 | Peringkat Top 3 | `.OrderByDescending(...).Take(3)` |
| 4 | Rata-rata + berapa di atas/bawah | `.Average(m => m.Nilai)` |
| 5 | Distribusi grade A/B/C/D/E | `.GroupBy(m => m.Grade).OrderBy(g => g.Key)` |
| 6 | Cari mahasiswa by nama | `.Where(m => m.Nama.Contains(input))` |

---

### 🔴 BAGIAN 5 — Simulasi Coding Test Nyata

Soal dengan tipe dan pola yang benar-benar muncul di screening test perusahaan. Disarankan dikerjakan dengan timer sebelum melihat output program.

---

#### `Soal 14` — Valid Parentheses — Stack Pattern

**Konsep:** `Stack<char>`, push/pop, karakter matching, empty check  
**Input:** String berisi kombinasi `(`, `)`, `[`, `]`, `{`, `}`  
**Output:** VALID atau TIDAK VALID + visualisasi isi stack setiap langkah

```
Input: "([{}])"

Operasi                        Stack State
------------------------------------------
PUSH '('                       [(]
PUSH '['                       [(, []
PUSH '{'                       [(, [, {]
POP '}' > '{' OK               [(, []
POP ']' > '[' OK               [(]
POP ')' > '(' OK               []
Stack kosong → VALID ✓
```

---

#### `Soal 15` — Data Transaksi — GroupBy & Sort

**Konsep:** LINQ `GroupBy`, `Select` anonymous type, `OrderByDescending`, `ThenBy`  
**Data:** 8 transaksi pre-loaded dari 4 customer  
**Output:** Ringkasan per customer — dari yang paling banyak transaksi. Jika jumlah sama, CustomerID terkecil lebih dulu.

**LINQ chain:**
```csharp
transaksis
    .GroupBy(t => t.CustomerID)
    .Select(g => new { CustomerID = g.Key, Jumlah = g.Count(), Total = g.Sum(t => t.Amount) })
    .OrderByDescending(x => x.Jumlah)  // primary sort
    .ThenBy(x => x.CustomerID)          // tiebreaker
```

---

#### `Soal 16` — Filter & Sort Array dengan Pola

**Konsep:** Pattern recognition, LINQ filtering, rule-based logic  
**Input:** Array angka sembarang dari user  
**Aturan:**
1. Ambil semua bilangan ganjil
2. Ikuti rantai turun-2 mulai dari yang pertama
3. Tambahkan nilai ganjil maksimum jika belum masuk
4. Urutkan descending

**Contoh lengkap dengan trace:**
```
Input     : [3, 5, 8, 6, 1, 4, 2, 7, 9]
Ganjil    : [3, 5, 1, 7, 9]
Max Ganjil: 9

Trace:
  Mulai: ambil ganjil pertama = 3
  5: diff=+2 (bukan -2), bukan max → SKIP
  1: diff=-2 ✓ TURUN DUA → masuk
  7: diff=+6, bukan max → SKIP
  9: adalah MAX GANJIL (9) → masuk

Output    : [9, 3, 1]
```

---

## 🚀 Cara Menjalankan

### Prasyarat

Pilih salah satu:
- **.NET SDK 6.0+** → https://dotnet.microsoft.com/download *(Direkomendasikan)*
- **Mono 6.x+** → https://www.mono-project.com/download/stable/ *(Alternatif Linux/macOS)*

---

### Opsi 1 — .NET SDK (Semua Platform)

```bash
# Clone repository
git clone https://github.com/YOUR_USERNAME/CSharpLearningLabs.git
cd CSharpLearningLabs

# Jika belum ada .csproj:
dotnet new console -o CSharpLearningLabs --force
cd CSharpLearningLabs
# Salin Program.cs dari repo ini ke folder project (overwrite yang ada)

# Jalankan
dotnet run
```

---

### Opsi 2 — Visual Studio 2022 (Windows)

```
1. File → New → Project → Console App (.NET) → Next
2. Project name: CSharpLearningLabs → Create
3. Hapus semua isi Program.cs yang ada
4. Copy seluruh isi Program.cs dari repo ini → Paste
5. Tekan F5 (atau Ctrl+F5 untuk run tanpa debug)
```

---

### Opsi 3 — VS Code

```bash
# Install ekstensi "C# Dev Kit" dari Microsoft di VS Code

git clone https://github.com/YOUR_USERNAME/CSharpLearningLabs.git
code CSharpLearningLabs

# Di terminal VS Code (Ctrl + `)
dotnet run
```

---

### Opsi 4 — Mono (Linux / macOS)

```bash
# Ubuntu/Debian:
sudo apt update && sudo apt install mono-complete

# macOS (Homebrew):
brew install mono

# Compile dan jalankan
mcs Program.cs -out:CSharpLab.exe
mono CSharpLab.exe
```

---

### Verifikasi Instalasi

Jika berhasil, terminal menampilkan:

```
╔══════════════════════════════════════════════════════════╗
║          C# LEARNING LAB — Interactive Exercises         ║
║        Belajar Sambil Langsung Uji Setiap Logika         ║
╚══════════════════════════════════════════════════════════╝

  [1] Bagian 1   — Logika & Kondisi Dasar    (4 soal)
  [2] Bagian 2   — Array & Manipulasi Data   (4 soal)
  [3] Bagian 3   — String Manipulation       (3 soal)
  [4] Bagian 4   — OOP — Dunia Nyata         (2 soal)
  [5] Bagian 5   — Simulasi Coding Test Real (3 soal)

  [0] Keluar

  Pilih bagian [0-5]:
```

---

## 📁 Struktur Project

```
CSharpLearningLabs/
│
├── Program.cs                          ← Seluruh kode (~1350 baris, single-file)
│   │
│   ├── ── ENTRY POINT ──
│   │   └── Main()                      Menu utama + routing ke bagian
│   │
│   ├── ── SUB-MENU ──
│   │   ├── Menu_Bagian1_LogikaKondisi()
│   │   ├── Menu_Bagian2_ArrayData()
│   │   ├── Menu_Bagian3_StringManipulasi()
│   │   ├── Menu_Bagian4_OOP()
│   │   └── Menu_Bagian5_CodingTest()
│   │
│   ├── ── IMPLEMENTASI SOAL ──
│   │   ├── Soal01_GanjilGenap()         Modulo, if-else
│   │   ├── Soal02_FizzBuzz()            Loop + multiple conditions
│   │   ├── Soal03_TahunKabisat()        Rule priority chain
│   │   ├── Soal04_Kalkulator()          Switch, TryParse, validation loop
│   │   ├── Soal05_MaxMinAvg()           Array traversal manual + trace
│   │   ├── Soal06_ReverseArray()        Two pointer swap visualization
│   │   ├── Soal07_HapusDuplikat()       HashSet vs sorted two pointer
│   │   ├── Soal08_TwoSum()              O(n²) vs O(n) side-by-side
│   │   ├── Soal09_Palindrome()          Two pointer on cleaned string
│   │   ├── Soal10_RLE()                 While-in-while + ordinal tracking
│   │   ├── Soal11_Anagram()             Frequency counter + freq table
│   │   ├── Soal12_BankAccount()         OOP simulation with state
│   │   ├── Soal13_SistemNilai()         6 LINQ queries selectable
│   │   ├── Soal14_ValidParentheses()    Stack push/pop visualization
│   │   ├── Soal15_DataTransaksi()       GroupBy + ThenBy pipeline
│   │   └── Soal16_FilterSortArray()     Rule-based pattern filter + trace
│   │
│   ├── ── MODEL CLASSES ──
│   │   ├── class BankAccount            Encapsulation demo (Soal 12)
│   │   └── class Mahasiswa              Computed properties (Soal 13)
│   │
│   └── ── UI HELPERS ──
│       ├── Warna(color, action)         Console color wrapper
│       ├── HeaderSoal(...)              Soal header + description
│       ├── TampilkanBox(lines, color)   Bordered result box
│       ├── TampilkanPenjelasan(lines)   Explanation section
│       ├── PesanError(msg)              Red error message
│       ├── BacaDouble(prompt)           Validated double input loop
│       └── ParseArrayInt(input)         Comma-separated int array parser
│
├── README.md                           ← Dokumentasi ini
└── .gitignore
```

---

## 🛠️ Teknologi & Dependencies

| Teknologi | Versi Min | Kegunaan |
|---|---|---|
| **C#** | 10.0+ | Bahasa utama |
| **.NET SDK** | 6.0+ | Runtime, compiler |
| **Mono** | 6.x+ | Alternatif runtime (Linux/macOS) |
| `System.Linq` | Built-in | Where, Select, GroupBy, OrderBy, Take, dll. |
| `System.Collections.Generic` | Built-in | List, Dictionary, Stack, HashSet |
| `System.Console` | Built-in | Colored output, user input |
| `System.Text` | Built-in | UTF-8 encoding |

> **Zero external dependencies.** Tidak ada NuGet package. Tidak ada library pihak ketiga. Cukup .NET SDK standar.

---

## 🧠 Konsep yang Dipelajari

### Fundamental C#

| Konsep | Di mana dipakai |
|---|---|
| Tipe data: `int`, `double`, `bool`, `char`, `string` | Semua soal |
| Operator aritmatika, logika, modulo | Soal 01–04 |
| `if-else`, `if-else if-else`, `switch-case` | Soal 01, 03, 04 |
| `for`, `while`, `do-while`, `foreach` | Soal 02, 04–16 |
| Method dengan parameter dan return value | Semua soal |
| `int.TryParse`, `double.TryParse` | Soal 04, semua input handler |
| String interpolation `$"..."` | Semua soal |
| Ternary operator `? :` | Soal 03, 12, 13 |

### Collections

| Tipe | Method Penting yang Dipakai | Soal |
|---|---|---|
| `int[]` | Indexing, `.Length`, `Array.Sort()` | 05–08 |
| `List<T>` | `.Add()`, `.ForEach()`, `.Count` | 10, 13–16 |
| `Dictionary<K,V>` | `.ContainsKey()`, `.Add()`, indexer | 07, 08, 10, 11 |
| `HashSet<T>` | `.Add()` (returns bool), `.Contains()` | 07 |
| `Stack<T>` | `.Push()`, `.Pop()`, `.Count` | 14 |

### LINQ

| Operator | Kegunaan | Soal |
|---|---|---|
| `.Where(predicate)` | Filter elemen | 09, 13, 16 |
| `.Select(transform)` | Transform / project | 15 |
| `.OrderByDescending()` / `.OrderBy()` | Sorting | 13, 15, 16 |
| `.ThenBy()` | Secondary sort (tiebreaker) | 15 |
| `.GroupBy(key)` | Kelompokkan by key | 13, 15 |
| `.Take(n)` | Ambil n elemen pertama | 13 |
| `.Average()`, `.Sum()`, `.Count()`, `.Max()` | Aggregasi | 13, 15 |
| `.Any()`, `.Contains()` | Boolean check | 04, 13 |

### OOP

| Konsep | Di mana dipakai |
|---|---|
| `class` declaration, constructor | Soal 12, 13 |
| `private` field, `public` property | Soal 12 |
| Read-only property (`get` only) | Soal 12 |
| Expression-body (computed) property | Soal 13 |
| Method dengan validasi dan side effects | Soal 12 |
| `override ToString()` | Soal 13 |

### Algoritma & Pola

| Pola | Di mana dipakai | Kompleksitas |
|---|---|---|
| Linear scan dengan tracking | Soal 05 | O(n) time, O(1) space |
| Two pointer | Soal 06, 07, 09 | O(n) time, O(1) space |
| Frequency counter | Soal 10, 11 | O(n) time, O(k) space |
| Complement lookup | Soal 08 | O(n) time, O(n) space |
| Stack bracket matching | Soal 14 | O(n) time, O(n) space |
| GroupBy aggregation | Soal 13, 15 | O(n) time |
| Rule-based filtering | Soal 16 | O(n) time |

---

## 🖥️ Contoh Output

### Soal 10 — Run-Length Encoding
```
  Masukkan string: aaaabbbccaabcccccc

  Input  : "aaaabbbccaabcccccc"
  Output :
    'a' pertama      = 4
    'b' pertama      = 3
    'c' pertama      = 2
    'a' kedua        = 2
    'b' kedua        = 1
    'c' kedua        = 6

  ── Cara Kerja Loop ──
  • Outer while: maju per GRUP
  • Inner while: hitung panjang grup (selama karakter sama)
  • Dictionary:  lacak sudah berapa kali tiap karakter muncul
```

### Soal 08 — Two Sum (Perbandingan Dua Algoritma)
```
  Array: 2,7,11,15   Target: 9

  ╔══════════════════════════════════════════════════════╗
  ║  Array      : [2, 7, 11, 15]                         ║
  ║  Target     : 9                                      ║
  ║                                                      ║
  ║  Naif  O(n²): index [0,1] → 2+7=9  (4 iterasi)     ║
  ║  Optimal O(n): index [0,1] → 2+7=9  (2 iterasi)    ║
  ╚══════════════════════════════════════════════════════╝

  ── Trace Cara Optimal ──
    i=0, arr[i]=2, cari complement=7
    → simpan dict[2]=0
    i=1, arr[i]=7, cari complement=2
    → KETEMU! dict[2]=index 0
```

### Soal 14 — Valid Parentheses (Stack Visualization)
```
  Masukkan string: ([{}])

  ╔══════════════════════╗
  ║  Input  : "([{}])"   ║
  ║  Hasil  : VALID ✓    ║
  ╚══════════════════════╝

  Operasi                        Stack State
  ------------------------------------------
  PUSH '('                       [(]
  PUSH '['                       [(, []
  PUSH '{'                       [(, [, {]
  POP '}' > '{' OK               [(, []
  POP ']' > '[' OK               [(]
  POP ')' > '(' OK               []
```

### Soal 12 — BankAccount (OOP Simulation)
```
  Nama pemilik rekening: Budi
  Saldo awal: 1000000

  Rekening 'Budi' dibuka. Saldo awal: 1,000,000

  ── Rekening: Budi | Saldo: 1,000,000 ──
  [1] Deposit   [2] Tarik   [3] Riwayat   [0] Kembali
  Pilihan: 1
  Jumlah deposit: 500000

  Deposit 500,000 berhasil. Saldo: 1,500,000

  Pilihan: 2
  Jumlah tarik: 3000000

  ✗ Saldo tidak cukup! Saldo: 1,500,000, Diminta: 3,000,000
```

---

## 🗺️ Roadmap

### ✅ v1.0 — Selesai
- 16 soal interaktif dengan trace visualisasi
- 5 kategori: Logika, Array, String, OOP, Coding Test
- Input user sendiri untuk semua soal
- Perbandingan algoritma O(n²) vs O(n)
- Validasi input yang robust di semua titik

### 🔄 v1.1 — Planned
- [ ] Soal 17 — Rekursi: Fibonacci + visualisasi call stack
- [ ] Soal 18 — Sliding Window: Maximum sum subarray K elemen
- [ ] Soal 19 — Binary Search dengan trace posisi `mid` setiap iterasi
- [ ] Soal 20 — Merge Sorted Arrays (fondasi merge sort)
- [ ] Soal 21 — First Unique Character in a String
- [ ] Soal 22 — Longest Common Prefix

### 🔮 v2.0 — Future
- [ ] Bagian 6 — Rekursi & Divide and Conquer (4 soal)
- [ ] Bagian 7 — Sorting Manual: Bubble, Selection, Merge Sort
- [ ] **Timer mode** — kerjakan soal dengan countdown, tampilkan waktu yang dibutuhkan
- [ ] **Score tracker** — simpan rekap soal yang berhasil ke file JSON
- [ ] **Hint system** — tekan `H` untuk hint bertahap sebelum lihat output program
- [ ] **Difficulty filter** — tampilkan hanya soal Easy / Medium / Hard

---

## ❓ FAQ

**Q: Apakah perlu IDE seperti Visual Studio untuk menjalankan ini?**  
A: Tidak. Cukup .NET SDK dan terminal biasa. Visual Studio adalah opsional.

**Q: Apakah bisa dijalankan di Linux atau macOS?**  
A: Ya, sepenuhnya lintas platform. Gunakan .NET SDK atau Mono.

**Q: Kenapa semua kode ada di satu file `Program.cs`?**  
A: Desain yang disengaja — satu file lebih mudah di-share, di-copy, dan dipelajari tanpa harus memahami struktur multi-file project terlebih dahulu. Cocok untuk tahap belajar.

**Q: Apakah soal-soal ini cukup untuk persiapan coding test?**  
A: Soal di sini mencakup pola-pola yang paling sering muncul di screening awal (junior level). Untuk persiapan lebih lanjut, lanjutkan ke LeetCode (easy–medium), HackerRank, atau Codewars (level 6–7 kyu).

**Q: Bagaimana cara menambah soal baru?**  
A: Buat method baru dengan format `SoalXX_NamaSoal()`, daftarkan di sub-menu yang sesuai dan di `Main()`. Lihat seksi Kontribusi untuk standar lengkapnya.

---

## 🤝 Kontribusi

Pull request sangat disambut! Untuk perubahan besar, buka issue terlebih dahulu.

### Cara Menambah Soal Baru

```csharp
// Naming convention: SoalXX_NamaCamelCase()
static void Soal17_NamaSoal()
{
    HeaderSoal("SOAL 17", "Judul Soal",
        "Deskripsi singkat apa yang dilakukan program.",
        "Pola: pola algoritma atau konsep utama.");

    while (true)
    {
        Console.Write("\n  Masukkan input (atau 'x' kembali): ");
        string input = Console.ReadLine();
        if (input?.ToLower() == "x") break;

        // === LOGIKA ===
        // ... implementasi ...

        // === OUTPUT ===
        TampilkanBox(new[] { "Hasil: ..." }, ConsoleColor.Green);

        // === TRACE / PENJELASAN ===
        TampilkanPenjelasan(new[] { "Penjelasan step 1...", "Penjelasan step 2..." });
    }
}
```

**Standar minimum setiap soal:**
- Header soal dengan deskripsi dan pola algoritma
- Input dari user (tidak boleh hardcode)
- Output yang jelas dalam box berwarna
- Trace atau penjelasan cara kerja
- Validasi input yang tidak crash saat input salah

### Commit Convention

```
feat: tambah Soal 17 - Rekursi Fibonacci dengan call stack
fix: perbaiki validasi input array di Soal 05
docs: update README - tambah contoh output Soal 16
refactor: ekstrak ParseArrayInt ke helper method terpisah
```

---

## 📄 Lisensi

```
MIT License

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
```

---

<div align="center">

Dibuat sebagai bagian dari perjalanan belajar C# — dari tidak tahu logika, menuju siap coding test profesional.

*"Programmer yang bagus bukan yang tidak pernah stuck.*  
*Yang bagus adalah yang tahu cara keluar dari stuck dengan sistematis."*

---

**⭐ Kalau repo ini membantu perjalanan belajarmu, kasih star! ⭐**

[![C#](https://img.shields.io/badge/-C%23-239120?style=flat-square&logo=csharp)](https://learn.microsoft.com/dotnet/csharp/)
[![.NET](https://img.shields.io/badge/-.NET-512BD4?style=flat-square&logo=dotnet)](https://dotnet.microsoft.com/)
[![Algorithms](https://img.shields.io/badge/-Algorithms-orange?style=flat-square)](#)
[![Data Structures](https://img.shields.io/badge/-Data%20Structures-blue?style=flat-square)](#)
[![OOP](https://img.shields.io/badge/-OOP-red?style=flat-square)](#)
[![LINQ](https://img.shields.io/badge/-LINQ-purple?style=flat-square)](#)

</div>
