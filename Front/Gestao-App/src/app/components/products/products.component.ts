import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.scss']
})
export class ProductsComponent implements OnInit {

  mostrarImagem: boolean = true;
  produtos: any = [];
  produtosFiltrados: any = [];
  filtroLista: string = "";
  marginImg: number = 2;
  widthImg: number = 50;
  constructor() { }

  ngOnInit() {
  }

}
