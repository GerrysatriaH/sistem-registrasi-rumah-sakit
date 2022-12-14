Public Class FungsiKamar

    Private tarifInap As Integer = 10000
    Private jumlahKamar As Integer = 100
    Private hariInap As Integer

    Private foto_pasien As String
    Private nama As String
    Private nik As String
    Private jenis_kelamin As String
    Private tanggal_lahir
    Private alamat
    Private layanan_value
    Private catatan_dokter
    Private keluhan_list As New List(Of String)

    '==================[ Getter & Setter ]=====================
    Public Property GSFoto() As String
        Get
            Return foto_pasien
        End Get
        Set(ByVal value As String)
            foto_pasien = value
        End Set
    End Property

    Public Property GSNama() As String
        Get
            Return nama
        End Get
        Set(ByVal value As String)
            nama = value
        End Set
    End Property

    Public Property GSNIK() As String
        Get
            Return nik
        End Get
        Set(ByVal value As String)
            nik = value
        End Set
    End Property

    Public Property GSJenisKelamin() As String
        Get
            Return jenis_kelamin
        End Get
        Set(ByVal value As String)
            jenis_kelamin = value
        End Set
    End Property

    Public Property GSTanggal_Lahir() As String
        Get
            Return tanggal_lahir
        End Get
        Set(ByVal value As String)
            tanggal_lahir = value
        End Set
    End Property

    Public Property GSAlamat() As String
        Get
            Return alamat
        End Get
        Set(ByVal value As String)
            alamat = value
        End Set
    End Property

    Public Property GSLayanan() As String
        Get
            Return layanan_value
        End Get
        Set(ByVal value As String)
            layanan_value = value
        End Set
    End Property

    Public Property GSKeluhan_List()
        Get
            Return keluhan_list
        End Get
        Set(ByVal value)
            keluhan_list = value
        End Set
    End Property

    Public Property GSCatatanDokter() As String
        Get
            Return catatan_dokter
        End Get
        Set(ByVal value As String)
            catatan_dokter = value
        End Set
    End Property

    Public Property GSTarifInap() As Integer
        Get
            Return tarifInap
        End Get
        Set(ByVal value As Integer)
            tarifInap = value
        End Set
    End Property

    Public Property GSJumlahKamar() As String
        Get
            Return jumlahKamar
        End Get
        Set(ByVal value As String)
            jumlahKamar = value
        End Set
    End Property

    '======================[ Getter ]==========================
    Public ReadOnly Property GetHariInap() As Integer
        Get
            Return hariInap
        End Get
    End Property

    '======================[ Setter ]==========================
    Public WriteOnly Property SetHariInap() As Integer
        Set(ByVal value As Integer)
            hariInap = value
        End Set
    End Property

    '======================[ Function ]========================
    Public Function HitungBiaya() As Integer
        Return hariInap * tarifInap
    End Function

    Public Function TambahKamar(requestKamar As Integer) As Integer
        jumlahKamar = jumlahKamar + requestKamar
        Return jumlahKamar
    End Function

    Public Function KurangiKamar(requestKamar As Integer) As Integer
        jumlahKamar = jumlahKamar - requestKamar
        Return jumlahKamar
    End Function
End Class