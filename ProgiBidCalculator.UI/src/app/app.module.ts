// It's used to serves as the root module that defines and configures the application's components, services, and dependencies.
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BidCalculatorComponent } from './pages/bidcalculator/bidcalculator.component';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { DecimalFormatterPipe } from './pipe/decimal-formatter.pipe';

@NgModule({
  declarations: [
    AppComponent,
    BidCalculatorComponent,
    DecimalFormatterPipe
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    ReactiveFormsModule,
    FormsModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
