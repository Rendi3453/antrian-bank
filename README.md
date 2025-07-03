# 💻 Aplikasi Antrian Bank - VB.NET

Proyek ini adalah aplikasi desktop berbasis **VB.NET (Windows Forms)** yang digunakan untuk mengelola sistem antrian nasabah di bank. Aplikasi memungkinkan pencatatan, pencetakan tiket, hingga export data.

---

## 🏗️ Struktur Proyek

- `FormMain.vb` - Tampilan utama (input nama nasabah, layanan, ambil antrian, cetak)
- `CetakForm.vb` - Preview/cetak tiket antrian
- `Form1.vb` (Opsional) - Testing atau halaman lainnya
- `App.config` - Konfigurasi aplikasi
- `AntrianBankIndividu.vbproj` - File project VB.NET
- `.gitignore` - Mengabaikan file tidak penting seperti `.vs/`, `bin/`, `obj/`, dll.

---

## 👥 Pembagian Tugas

| Anggota       | Peran                          | Deskripsi                                                                 |
|---------------|--------------------------------|--------------------------------------------------------------------------|
| 🧑‍🎨 Front-End | **(Sudah Dikerjakan)**         | UI Form: Input antrian, cetak tiket, tampilkan antrian di DataGridView  |
| 🧑‍💻 Back-End  | Koneksi Database, CRUD, Autonumber | Buat koneksi ke DB, simpan data antrian, generate nomor otomatis        |
| 🧑‍🔧 Ekspor    | Export PDF/Excel & Fitur Suara | Export data ke file, fitur panggilan suara, dll                         |
| 🧑‍💼 Integrator| Testing, penggabungan, installer | Gabungkan semua modul & build aplikasi final                            |

---

## 🔌 Teknologi yang Digunakan

- Visual Studio 2022
- .NET Framework (bukan .NET Core)
- Bahasa: **VB.NET**
- Database: Microsoft Access / SQL Server (akan ditentukan oleh Back-End)

---

## 🚀 Cara Menjalankan

1. Buka dengan **Visual Studio**
2. Jalankan file `AntrianBankIndividu.sln`
3. Klik `Start` (tombol hijau)

---

## 🗃️ Rencana Fitur (Minimum)

- [x] UI Form Pengambilan Antrian
- [ ] Simpan ke database
- [ ] Cetak Tiket
- [ ] Suara panggil otomatis
- [ ] Export ke PDF / Excel
- [ ] Filter berdasarkan tanggal/hari

---

## 📌 Catatan

- File build seperti `.exe`, `.pdb`, `bin/`, dan cache `.vs/` tidak dikirim ke GitHub.
- Tambahkan dokumentasi setiap fitur jika kamu menambahkan file baru.

---

## ✍️ Kontribusi

Silakan buat branch baru sesuai bagian tugasmu:
