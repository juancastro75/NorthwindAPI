import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public empleados: Employee[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Employee[]>(baseUrl + 'api/Employee').subscribe(result => {
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
