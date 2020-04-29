package tugas_modul5;
class userService {
private String[][] data = new String[2][3];
private String[][] histories = new String [2][5];
    private String email, password, roles = "";
    
    //ini namanya constructor yang akan dijalankan setiap class diinisialisasikan
    public userService(String emails, String passwords)
    {
        email = emails;
        password = passwords;
        String[][] data = 
        { 
            {"ahmadkelompok73@gmail.com", "12345", "superAdmin"},
            {"raflykelompok73@gmail.com", "12345", "user"} 
        };
        String[][] histories = 
        {
            {"ahmadkelompok73@gmail.com","Fisika Dasar II","Dasar Komputer dan Pemrograman","Sistem Digital","26-04-2020"},
            {"raflykelompok73@gmail.com","Konsep Jaringan Komputer","Dasar Komputer dan Pemrograman","Kalkulus","26-04-2020"}
        };
        this.data = data;
        this.histories = histories;
    }
    
    private boolean checkCredential()
    {
        for(int i = 0; i < data.length; i++ )
        {
            if(data[i][0].equals(email))
            {
                if(data[i][1].equals(password))
                {
                    int buku;
                    if(data[i][0].equals(histories[i][0]))
                        buku = i;
                }
                {
                    roles = data[i][2];
                    return true;
                }
            }
        }
        return false;
    }
    
    public void login()
    {
        boolean status = checkCredential();
        if(status == true)
        {
            System.out.println("\nWelcome " + roles);
            System.out.println("Logged it as user email " + email);
            int buku = 0;
            for (int i=1;i<4;i++) {
                System.out.println(histories[buku][i]);
            }
            System.out.println("Tanggal Peminjaman : " + histories[buku][4]);
        }
        else
        {
            System.out.println("\nInvalid Login ");
        }
    }   
}
