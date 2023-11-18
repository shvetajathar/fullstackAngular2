import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { IMovie } from '../model/imovie';
import { HttpClient,HttpHeaders } from '@angular/common/http';
// import { HttpResponse } from '@angular/common/http';
@Injectable({
  providedIn: 'root'
})
export class MovieService {
  private url='https://8080-beaddfcabfedbecfabcaaaceeafebeccaddbefddaf.premiumproject.examly.io/Movie)'
  private url2='https://8080-beaddfcabfedbecfabcaaaceeafebeccaddbefddaf.premiumproject.examly.io/Detail'

  constructor(private httpclient:HttpClient) { }
  getAllMovies():Observable<any[]>
  {
    return this.httpclient.get<any[]>(this.url+'/listmovies')
  }
  httpOptions={headers:new HttpHeaders({'Content-type':'application/json'})}
  addMovie(moviedata:IMovie):Observable<IMovie>
  {
    return this.httpclient.post<IMovie>(this.url + '/AddMovie',moviedata, this.httpOptions)
  }
}
