using Carouselview_XF.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Carouselview_XF.Datas
{
    public class EtkinlikData
    {
        public List<EtkinlikModel> EtkinlikModel = new List<EtkinlikModel>()
        {
            new EtkinlikModel()
            {
                 EtkinlikImage="ankara.png",
                 EtkinlikName="ANKARA BULUŞMASI",
                 EtkinlikDescription="Alzheimer hasta ve hasta yakını bilgilendirici etkinliğimiz 28 Aralık Cuma günü gerçekleştirilecektir." +
                                     "\n"+"Büyük buluşmamıza hepinizi bekleriz..."
            },
             new EtkinlikModel()
            {
                 EtkinlikImage="istanbul.png",
                 EtkinlikName="İSTANBUL BULUŞMASI",
                 EtkinlikDescription="Alzheimer hasta ve hasta yakını bilgilendirici etkinliğimiz 28 Aralık Cuma günü gerçekleştirilecektir." +
                                     "\n"+"Büyük buluşmamıza hepinizi bekleriz..."
            },
              new EtkinlikModel()
            {
                 EtkinlikImage="izmir.png",
                 EtkinlikName="İZMİR BULUŞMASI",
                 EtkinlikDescription="Alzheimer hasta ve hasta yakını bilgilendirici etkinliğimiz 28 Aralık Cuma günü gerçekleştirilecektir." +
                                     "\n"+"Büyük buluşmamıza hepinizi bekleriz..."
            }
        };
    }
}
