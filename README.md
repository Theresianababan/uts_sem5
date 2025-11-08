## Informasi Pribadi

| **Atribut**      | **Detail**               |
|------------------|--------------------------|
| **Nama**         | Theresia A K Nababan  |
| **NIM**          | 312310670               |
| **Kelas**        | TI.23.A5                 |
| **Mata Kuliah**  | Pemrograman Visual       |

## Deskripsi

Halo! Saya Theresia A K Nababan, mahasiswa di program studi Teknik Informatika, kelas TI.23.A5. Saya sedang mengikuti mata kuliah **Pemrograman Visual**, yang berfokus pada pengembangan aplikasi menggunakan prinsip-prinsip desain visual untuk menciptakan antarmuka pengguna yang menarik dan fungsional.

Sebagai bagian dari mata kuliah ini, saya mengembangkan beberapa proyek yang memanfaatkan konsep-konsep desain antarmuka visual, serta pengembangan aplikasi berbasis grafis dan multimedia.

## Tujuan dan Fokus Proyek

Dalam mata kuliah **Pemrograman Visual**, saya fokus pada:
- **Desain Antarmuka Pengguna (UI)**: Mempelajari bagaimana merancang antarmuka yang intuitif dan user-friendly.
- **Pemrograman Aplikasi Grafis**: Menggunakan berbagai framework dan alat untuk membuat aplikasi dengan elemen grafis interaktif.
- **Pengembangan Multimedia**: Menyusun elemen-elemen visual dan multimedia yang menyatu dalam aplikasi untuk meningkatkan pengalaman pengguna.

## Keterampilan

| **Keahlian**           | **Detail**                      |
|------------------------|---------------------------------|
| **Bahasa Pemrograman** | Python, JavaScript, HTML, CSS   |
| **Framework**          | React, Bootstrap, Tkinter       |
| **Alat Desain**        | balsamic                        |
| **Database**           | MongoDB, MySQL                  |

## Kontak

Jika kamu ingin berdiskusi atau memiliki pertanyaan terkait proyek atau mata kuliah ini, jangan ragu untuk menghubungi saya melalui:
- **Email**: [nababantheresia84@gmail.com]

---

# Toko Baju

Toko baju adalah tempat yang menjual berbagai jenis pakaian untuk memenuhi kebutuhan berbusana masyarakat. Di dalamnya tersedia beragam model, ukuran, dan gaya pakaian yang dapat dipilih sesuai selera dan keperluan pembeli. Tujuan toko baju adalah menyediakan pakaian yang berkualitas dan nyaman bagi konsumen.

## 1. Setting Web Service dan Configuration Web

Untuk menggunakan toko baju, pastikan kamu telah melakukan konfigurasi web service dan pengaturan aplikasi dengan benar. Berikut adalah langkah-langkah konfigurasi yang perlu dilakukan:

### 1.1 **Install Dependencies (Untuk Backend dan Frontend)**

- **Backend (ASP.NET)**:
   - Pastikan kamu sudah menginstall **.NET SDK** dan **Runtime** pada mesin kamu.
   - Gunakan perintah berikut untuk menginstall dependensi di sisi backend:
     ```bash
     dotnet restore
     ```
   - Untuk menjalankan server backend, gunakan perintah berikut:
     ```bash
     dotnet run
     ```
   - Pastikan bahwa server ASP.NET berjalan pada `http://localhost:5258/` (atau sesuai dengan pengaturan port yang telah dikonfigurasi).

- **Frontend (Bootstrap)**:
   - Proyek ini menggunakan **Bootstrap** untuk desain responsif dan antarmuka pengguna yang ramah.
   - Untuk menjalankan frontend secara lokal, cukup buka file `index.html` di browser atau gunakan server lokal jika ingin lebih interaktif.
   - Untuk menginstall dependensi frontend jika diperlukan:
     ```bash
     npm install
     ```

### 1.2 **Konfigurasi Database dengan MongoDB Compass**

- **Instalasi MongoDB Compass**:
   - Pastikan **MongoDB Compass** sudah terpasang di mesin kamu untuk memanage database.
   - Jika belum, kamu bisa mengunduhnya [di sini](https://www.mongodb.com/products/compass).

- **Pengaturan Database**:
   - Buka file konfigurasi di `config/database.js` dan pastikan untuk mengonfigurasi URI MongoDB kamu.
   - Contoh konfigurasi:
     ```javascript
     const mongoose = require('mongoose');
     mongoose.connect('mongodb://localhost:27017/toko baju', { useNewUrlParser: true, useUnifiedTopology: true });
     ```

- **Jalankan MongoDB**:
   - Jika menggunakan MongoDB secara lokal, pastikan server MongoDB kamu berjalan dengan perintah:
     ```bash
     mongod
     ```
   - Jika menggunakan MongoDB Atlas, pastikan kamu mendapatkan connection string dan menggantinya di `database.js`.

### 1.3 **Menjalankan Server**

- Setelah konfigurasi di atas selesai, kamu dapat menjalankan server menggunakan perintah:
   ```bash
   dotnet run


2. Nama Project dan Penjelasan Penggunaannya

Nama Project: toko baju

Penjelasan:

Toko baju adalah tempat yang menjual berbagai jenis pakaian untuk memenuhi kebutuhan berbusana masyarakat. Di dalamnya tersedia beragam model, ukuran, dan gaya pakaian yang dapat dipilih sesuai selera dan keperluan pembeli. Tujuan toko baju adalah menyediakan pakaian yang berkualitas dan nyaman bagi konsumen.

Alasan Menggunakan toko baju:

1.1 Saya memilih project toko baju karena pakaian adalah kebutuhan pokok yang selalu dibutuhkan setiap orang, sehingga peluang usahanya cukup besar dan terus ada peminatnya. Selain itu, sistem pengelolaannya relatif mudah dipahami, mulai dari pencatatan barang hingga proses penjualan. Dengan project ini, saya dapat belajar mengelola usaha ritel, memahami alur transaksi, serta melatih kemampuan dalam mengatur stok dan melayani pelanggan.

1.2 Data Produk / Stok Barang
Berisi informasi lengkap mengenai pakaian yang dijual, seperti nama item, ukuran, warna, harga, dan jumlah stok yang tersedia. Bagian ini penting untuk memudahkan pengaturan dan pengecekan barang.

1.3 Data Pelanggan
Berisi catatan atau informasi mengenai pembeli, seperti nama serta kontak (jika diperlukan). Tujuannya untuk mengenal pelanggan dan mempermudah pelayanan atau penyimpanan riwayat pembelian.

1.4 Proses Penjualan
Bagian ini mencakup kegiatan transaksi antara toko dan pelanggan, mulai dari pemilihan barang, pembayaran, hingga pencetakan nota atau bukti pembelian. Ini menunjukkan bagaimana barang keluar dari stok dan berubah menjadi pendapatan.

1.5 Laporan Penjualan
Berupa catatan hasil penjualan dalam jangka waktu tertentu (harian, mingguan, atau bulanan). Laporan ini digunakan untuk mengetahui keuntungan, jumlah penjualan, serta mengevaluasi perkembangan usaha.

1.6 Pengelolaan Stok
Proses pengecekan dan pengaturan jumlah barang agar stok tidak kehabisan atau berlebih. Bagian ini sangat penting untuk menjamin ketersediaan produk dan menjaga kelancaran usaha.

6. MOCK UP

Home
<img width="1889" height="915" alt="home" src="https://github.com/user-attachments/assets/4eeabddd-29a3-4904-8214-766a4b67eb20" />


halaman register
<img width="1867" height="906" alt="halaman register" src="https://github.com/user-attachments/assets/7a9f89dd-98e6-46d5-b351-27449149cb4a" />


halaman masuk
<img width="1890" height="904" alt="halaman masuk" src="https://github.com/user-attachments/assets/bda5f7e0-4225-4dec-bfb7-07a938a01756" />



**HALAMAN USER**

beranda user
<img width="1865" height="902" alt="user (2)" src="https://github.com/user-attachments/assets/100a8180-4f43-43cf-b517-843a38333001" />


halaman layanan baju
<img width="1867" height="907" alt="beranda" src="https://github.com/user-attachments/assets/da5f2100-70d5-4e94-9d75-71e657a10c44" />

halaman keranjang
<img width="1891" height="903" alt="keranjang" src="https://github.com/user-attachments/assets/d4abf8b5-2572-4970-b920-148e0d612bf1" />


halaman pesanan user
<img width="1890" height="899" alt="pesanan" src="https://github.com/user-attachments/assets/81ab1a91-d1bd-455c-a500-13034cf9b0b1" />

halaman profile  
<img width="1897" height="917" alt="provil" src="https://github.com/user-attachments/assets/3a538509-454f-4220-821a-442f54887daf" />



**HALAMAN ADMIN**

halaman dashbord
<img width="1898" height="917" alt="halaman dasboard(admin)" src="https://github.com/user-attachments/assets/6a9d4495-b61e-444e-91f0-53a49fb7d294" />

halaman produk
<img width="1877" height="913" alt="produk (admin)" src="https://github.com/user-attachments/assets/9ccf9d79-d132-48bc-b3dc-acf902827620" />


halaman pesanan
<img width="1894" height="908" alt="pesanan ( admin)" src="https://github.com/user-attachments/assets/27b3c3da-68f7-47ba-9e82-ea1848f0cbd9" />


halaman kelola user
<img width="1901" height="919" alt="halaman kelolah user" src="https://github.com/user-attachments/assets/874b75e5-c00f-497b-9701-1e93f4e05e94" />
