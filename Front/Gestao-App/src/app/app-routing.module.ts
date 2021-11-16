import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CostumersComponent } from './components/costumers/costumers.component';
import { DashboardComponent } from './components/dashboard/dashboard.component';
import { OrdersComponent } from './components/orders/orders.component';
import { ProductsComponent } from './components/products/products.component';

const routes: Routes = [
  { path: 'Clientes', component: CostumersComponent },
  { path: 'Produtos', component: ProductsComponent },
  { path: 'Dashboard', component: DashboardComponent },
  { path: 'Pedidos', component: OrdersComponent },
  { path: '', redirectTo: 'Dashboard', pathMatch: 'full'},
  { path: '**', redirectTo: 'Dashboard', pathMatch: 'full'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
