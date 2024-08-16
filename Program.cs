using DesafioPOO.Models;

Iphone iphone = new Iphone("17912341234", "iPhone 12 Pro", "123456789", 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");

Nokia nokia = new Nokia("17943214321", "Nokia G11 Plus", "987654321", 128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("LinkedIn");