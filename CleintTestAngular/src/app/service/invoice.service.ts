import { Injectable, OnInit } from '@angular/core';

import {HttpClient} from '@angular/common/http';
import { Invoice } from '../Models/Invoice';


@Injectable({
  providedIn: 'root'
})
export class InvoiceService implements OnInit {
  
  
  constructor(private client: HttpClient) { 

  }

  ngOnInit(): void {
    
  }

  getData ()
  {
    let url = "http://localhost:11780/test";
    return this.client.get<Invoice[]>(url);
  }

}
