import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { VehiclesComponent } from './vehicles/vehicles.component';
import { VehicleFormComponent } from './Vehicles/vehicle-form/vehicle-form.component';

@NgModule({
  declarations: [
    AppComponent,
    VehiclesComponent,
    VehicleFormComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
