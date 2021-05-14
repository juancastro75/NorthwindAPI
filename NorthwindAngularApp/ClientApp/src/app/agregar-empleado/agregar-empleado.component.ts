import { Component, Inject, OnInit } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { FormGroup, FormControl } from '@angular/forms';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-agregar-empleado',
  templateUrl: './agregar-empleado.component.html',
  styleUrls: ['./agregar-empleado.component.css']
})
export class AgregarEmpleadoComponent implements OnInit {

  private baseURL = location.origin;

  profileForm = new FormGroup({
    nombre: new FormControl(''),
    apellido: new FormControl(''),
    pais: new FormControl(''),
    direccion: new FormControl(''),
  });

  constructor(private http: HttpClient) { }

  ngOnInit() {
  }

  onSubmit(): Observable<Employee> {
    console.warn(this.profileForm.value);

    console.log(JSON.stringify(this.profileForm.value));

    console.log(this.baseURL);

    console.log(this.baseURL + 'api/Employee');

    return this.http.post<Employee>(this.baseURL + '/api/Employee', JSON.stringify(this.profileForm.value));
  }

}

interface Employee {
  nombre: string;
  apellido: string;
  pais: string;
  direccion: string;
}
