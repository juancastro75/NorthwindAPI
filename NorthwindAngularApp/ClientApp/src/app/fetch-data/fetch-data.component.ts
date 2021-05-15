import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from "../../environments/environment";

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public empleados: Employee[];

  constructor(http: HttpClient) {
    http.get<Employee[]>(environment.ApiConfig.url).subscribe(result => {
      this.empleados = result;
    }, error => console.error(error));
  }
}

interface Employee {
  id: number;
  nombre: string;
  apellido: string;
  pais: string;
  ciudad: string;
  direccion: string;
  fechaNacimiento: string;
}
