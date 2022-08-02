const play = document.querySelector("#play")
const stop = document.querySelector("#stop")
const pause = document.querySelector("#pause")
const hour = document.querySelector("#hour")
const minute = document.querySelector("#minute")
const second = document.querySelector("#second")
const bitir = document.querySelector("#bitir")
const time = document.querySelector(".testtime")
const containerSonuc = document.querySelector(".containerSonuc")
const containerSure = document.querySelector(".containerSure")
const oftime = document.querySelector(".offtime")
const btnAna = document.querySelector("#btnAna")
const testName = document.querySelector("span")
const clock = document.querySelector(".clock")
const suresaniye=8100
var Interval;
var sure;
var saniye = 00, dakika=00, saat=00;

play.addEventListener("click", () =>{
   clearInterval(Interval)
   Interval=setInterval(startime,0,001);
});

pause.addEventListener("click", () =>{
    clearInterval(Interval)
    
 });

 stop.addEventListener("click", () =>{
    clearInterval(Interval)
    saniye = 00;
    dakika = 00;
    saat = 00;
    second.innerHTML="0" +saniye;
    minute.innerHTML="0" +dakika;
    hour.innerHTML="0" +saat;
    
 });


 bitir.addEventListener("click", ()=>{
    clearInterval(Interval) 
    swal({      
        title: "Emin misin",
        text: "Süren sıfırlanacak",
        icon: "warning",
        buttons: true,
        dangerMode: true,
      })
      .then((willDelete) => {
        if (willDelete) {
            testName.style.opacity=0;
            clearInterval(Interval)
            sureGercek = saat*60*60+dakika*60+saniye;
            sure = saat.toString()+":"+dakika.toString()+":"+saniye.toString()
            saniye = 00;
            dakika = 00;
            saat = 00;
            second.innerHTML="0" +saniye;
            minute.innerHTML="0" +dakika;
            hour.innerHTML="0" +saat;
            containerSure.style.opacity = 0.05;
            containerSure.style['pointer-events'] = "none";
            if (sureGercek < suresaniye) {
                containerSonuc.classList.remove("d-none")
                time.classList.add("text-success")
                time.innerHTML=sure;
                swal("Süreniz başarıyla kaydedildi", {
                    icon: "success",
                    
                  });
            }else{
               
                containerSonuc.classList.remove("d-none")
                time.classList.add("text-danger")
                time.innerHTML=sure;
                let kalansure = kpsssaniye - sureGercek;
                let divKalan = `Süreyi ${kalansure} saniye kadar aştınız`;
                oftime.innerHTML=divKalan;
                btnAna.classList.remove("d-none")
                            
            } 
          
        }else{
            sureGercek = saat*60*60+dakika*60+saniye;
            console.log(sureGercek)
            if (sureGercek > suresaniye) {
                hour.classList.add("bg-danger")
                minute.classList.add("bg-danger")
                second.classList.add("bg-danger")
            }
           Interval=setInterval(startime,0,001);
        } 
        
      });
      
 })
function startime(){
    saniye++;
    if (saniye <= 9) {
        second.innerHTML = "0" + saniye;
    }
    if (saniye > 9) {
        second.innerHTML = saniye;
    }
    if (saniye > 59) {
        dakika++;
        minute.innerHTML = "0" + dakika;
        saniye =0;
        second.innerHTML = "0" + saniye;
    }
    
    if (dakika > 9) {
        minute.innerHTML = dakika;
    }
    if (dakika > 59) {
        saat++;
        hour.innerHTML="0"+saat;
        dakika=0;
        minute.innerHTML="0"+dakika;
    }
}