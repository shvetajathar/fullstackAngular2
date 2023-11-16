import { Injectable } from '@angular/core';
import { IMovie } from '../model/imovie';
import { Observable } from 'rxjs';
import { HttpClient,HttpHeaders } from '@angular/common/http';
@Injectable({
  providedIn: 'root'
})
export class MovieserviceService {

  constructor() { }
}
