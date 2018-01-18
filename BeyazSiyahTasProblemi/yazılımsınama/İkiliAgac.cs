using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yazılımsınama
{
    public class İkiliAgac
    {
        private İkiliAgacDugumu kok;
        public İkiliAgacDugumu isaretci;

        public İkiliAgac(İkiliAgacDugumu kok)
        {
            this.kok = kok;
        }
        public void agacolustur(İkiliAgacDugumu a,int deger)
        {
            int s = a.seviye;
            for (int j = s; j < deger; j++)
            {
                isaretci = a;
                for (int i = 0; i < deger - a.seviye; i++)
                {
                    if (i % 2 == 0)
                    {
                        İkiliAgacDugumu siyah = new İkiliAgacDugumu("Siyah", isaretci.seviye+1);
                        isaretci.sag = siyah;
                        isaretci = isaretci.sag;
                    }
                    else
                    {
                        İkiliAgacDugumu beyaz = new İkiliAgacDugumu("Beyaz", isaretci.seviye+1);
                        isaretci.sag = beyaz;
                        isaretci = isaretci.sag;
                    }


                }       
                    İkiliAgacDugumu bbeyaz = new İkiliAgacDugumu("Beyaz", j + 1);
                    a.sol = bbeyaz;
                    a = a.sol;
            }

        }
        public void agacolustur2(İkiliAgacDugumu b,int deger)
        {
            İkiliAgacDugumu isaretci2 = b;
            for (int j = 0; j < (deger - b.seviye) / 2; j++)
            {
                if (isaretci2.sag.sag.veri.ToString() == "Beyaz")
                {
                    isaretci2 = isaretci2.sag.sag;
                    if (isaretci2.seviye!=deger)
                    {
                        İkiliAgacDugumu node = new İkiliAgacDugumu("Beyaz", isaretci2.seviye + 1);
                        isaretci2.sol = node;
                        agacolustur(node,deger);
                        agacolustur2(node,deger);
                    }
                }
                else
                {

                }
            }
            while (b.sol != null)
            {
                b = b.sol;
                agacolustur2(b,deger);
            }
            }
        int toplamdurumsayisi=0;
        
        public void kokunsolunusay(İkiliAgacDugumu k,int deger)
          {
            İkiliAgacDugumu kok = k;
            int sayac=k.seviye;
            int soldurumsayisi = 0;

            for (int m = 0; m < deger- k.seviye; m++)
            {
                İkiliAgacDugumu d = k;
                
                for (int i = 0; i < deger - sayac; i++)
                {
                  
                        d = d.sol;
                    
                    if(d.seviye==deger)
                    {
                        soldurumsayisi++;
                        break;
                    }
                }
                for (int j = k.seviye; j < sayac; j++)
                {
                    d = d.sag;
                    if(d.seviye==deger)
                    {
                        soldurumsayisi++;
                    }
                    if(d.veri.ToString()=="Beyaz")
                    {
                        kokunsolunusay(d,deger);
                    }
                }
                sayac++;
            }
            toplamdurumsayisi += soldurumsayisi;
        }
        public void durumlarısay(İkiliAgacDugumu k,int deger)
        {
            İkiliAgacDugumu kok = k;
            int sayac = k.seviye;
            İkiliAgacDugumu isaretci3 = k;
            while(isaretci3.sag!=null)
            {
                isaretci3 = isaretci3.sag;
                if(isaretci3.veri.ToString()=="Beyaz")
                {
                    kokunsolunusay(isaretci3,deger);
                }
            }
            toplamdurumsayisi++;
        }
        public int durumsayisi()
        {
            return toplamdurumsayisi; 
        }
        }
    }

        
    


