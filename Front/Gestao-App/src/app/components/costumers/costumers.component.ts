import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-costumers',
  templateUrl: './costumers.component.html',
  styleUrls: ['./costumers.component.css']
})
export class CostumersComponent implements OnInit {

  costumers: any = [];
  costumersFiltered: any = [];
  private _filtroLista: string = '';

  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.getCostumers();
  }


  public get filtroLista(): string{
    return this._filtroLista;
  }

  public set filtroLista(value: string){
    this._filtroLista = value;
    this.costumersFiltered = this.filtroLista ? this.filtrar(this.filtroLista) : this.costumers;
  }

  filtrar(filtrarPor: string): any{
    filtrarPor = filtrarPor.toLocaleLowerCase();
    return this.costumers.filter(
      (costumer: any) => costumer.nome.toLocaleLowerCase().indexOf(filtrarPor) !== -1 ||
      costumer.contato.toLocaleLowerCase().indexOf(filtrarPor) !== -1
      );
  }

  getCostumers() : void {
    this.http.get('https://localhost:5001/api/costumer').subscribe(
      response => {
        this.costumers = response;
        this.costumersFiltered = this.costumers;
      },
      error => console.log(error)
      );
    }

}
