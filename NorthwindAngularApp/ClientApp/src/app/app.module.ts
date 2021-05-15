import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { AgregarEmpleadoComponent } from './agregar-empleado/agregar-empleado.component';
import { EliminarEmpleadoComponent } from './eliminar-empleado/eliminar-empleado.component';
import { ReactiveFormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    FetchDataComponent,
    AgregarEmpleadoComponent,
    EliminarEmpleadoComponent,
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    RouterModule.forRoot([
      { path: '', component: FetchDataComponent, pathMatch: 'full' },
      { path: 'agregar-empleado', component: AgregarEmpleadoComponent },
      { path: 'eliminar-empleado', component: EliminarEmpleadoComponent },
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})

export class AppModule {}
