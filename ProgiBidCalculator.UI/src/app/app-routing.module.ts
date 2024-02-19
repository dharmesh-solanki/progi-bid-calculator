//used to define and configure the routing structure for the application.
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { BidCalculatorComponent } from './pages/bidcalculator/bidcalculator.component';

const routes: Routes = [
  { path: '', redirectTo:'calculate-price',pathMatch:'full'},
  { path: 'calculate-price', component: BidCalculatorComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
