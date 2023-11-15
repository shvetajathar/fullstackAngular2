import { Injectable } from '@angular/core';
import { IMovie } from '../model/imovie' ;
import {HttpClient,HttpHeaders} from '@angular/common/http';
import { Observable } from 'rxjs';
@Injectable({
  providedIn: 'root'
})
export class MovieService {
private url='https://8080-beaddfcabfedbecfabcaaaceeafebeccaddbefddaf.premiumproject.examly.io/Movie)'
  constructor(private httpclient:HttpClient) { }
  getAllMovies():Observable<any[]>{
    return this.httpclient.get<any[]>(`${this.url}/listmovies`)

    }
}
