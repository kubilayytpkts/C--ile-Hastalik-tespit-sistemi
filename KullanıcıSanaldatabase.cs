using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public static class KullanıcıSanaldatabase
    {
        static public List<Kullanıcı> KullanıcıDB = new List<Kullanıcı>()
        {
         new Kullanıcı()
         {
             Tckimlik="",
             yaş="",
             Cinsiyet=""
          
         }
        };

        public static List<Cinsiyet> Kullanıcıcinsiyet = new List<Cinsiyet>()
        {
        new Cinsiyet{_cinsiyet="Erkek"},
        new Cinsiyet{_cinsiyet="Kadın"}

        };

        public static List<Semptomlar> BelirtilerDB = new List<Semptomlar>()
        {
            new Semptomlar{ Hastalıkbelirtileri="Burun Tıkanıklığı"},
            new Semptomlar{ Hastalıkbelirtileri="Baş ağrısı" },
            new Semptomlar{Hastalıkbelirtileri="Nefes Almada zorluk" },
            new Semptomlar{ Hastalıkbelirtileri="Yüzde Şişkinlik" },
            new Semptomlar{Hastalıkbelirtileri="Boğazada Gıcık" },
            new Semptomlar{ Hastalıkbelirtileri="Yutkunmada zorluk"},
            new Semptomlar{ Hastalıkbelirtileri="Baş dönmesi"},
            new Semptomlar{Hastalıkbelirtileri="Kulak çınlaması" },
            new Semptomlar{Hastalıkbelirtileri="Vücud direncinin düşmesi" },
            new Semptomlar{Hastalıkbelirtileri="Ağız kenarlarında çatlaklar" },
            new Semptomlar{Hastalıkbelirtileri="eklem yerlerinde ağrı"},
            new Semptomlar{Hastalıkbelirtileri="Başta basınç hissi" },
            new Semptomlar{Hastalıkbelirtileri="Görmede bulanıklık" },
            new Semptomlar{Hastalıkbelirtileri="Burun kanaması" },
            new Semptomlar{Hastalıkbelirtileri="Bademciklerde Ağrı" },
            new Semptomlar{Hastalıkbelirtileri="Sabahları miğde bulantısı ve öğürme" },
        };


          

      


    }
}
