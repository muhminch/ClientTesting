import { Component, OnInit } from '@angular/core';
import { Invoice } from './Models/Invoice';
import { InvoiceService } from './service/invoice.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{
  title = 'ClientTestApplication';

  data: Invoice[] = new Array<Invoice>();

  constructor(private service: InvoiceService){
    this.service.getData().subscribe(data => {
      this.data = data;
      console.log(data);
  })
  }
  ngOnInit(): void {

    this.service.getData().subscribe(data => {
        this.data = data;
        console.log(data);
    })

  }
}


