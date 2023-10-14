using Adapter;

IPago pago = new PagoTransferencia();
Ventas venta = new Ventas(pago);
venta.ProcesarPago();

IPago pago1 = new PagoEfectivo();
Ventas venta1 = new Ventas(pago1);
venta1.ProcesarPago();

IPago pago2 = new PagoConAguacates();
Ventas venta2 = new Ventas(pago2);
venta2.ProcesarPago();

IPago pago3 = new PagoCuerpomatic();
Ventas venta3 = new Ventas(pago3);
venta3.ProcesarPago();

IPago pagoTC = new PagoTarjetaCredito("0123");
Ventas ventaTC = new Ventas(pagoTC);
ventaTC.ProcesarPago();

IPago pagoTrueke = new PagoTrueque("Vaca");
Ventas ventaTrueke = new Ventas(pagoTrueke);
ventaTrueke.ProcesarPago();

IPago pagoBit = new PagoBitcoin("Cta.Bill.Bit");
Ventas ventaBit = new Ventas(pagoBit);
ventaBit.ProcesarPago();