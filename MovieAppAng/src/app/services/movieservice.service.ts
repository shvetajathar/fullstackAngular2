import { Injectable } from '@angular/core';
import { IMovie } from '../model/imovie';
import { Observable } from 'rxjs';
import { HttpClient,HttpHeaders } from '@angular/common/http';
@Injectable({
  providedIn: 'root'
})
export class MovieserviceService {
  private url="https://8080-beaddfcabfedbecfabcaaaceeafebeccaddbefddaf.premiumproject.examly.io/Movie)"

  constructor(private httpclient:HttpClient) { }

  getAllMovies():Observable<any[]>
  {
      return this.httpclient.get<any[]>(this.url+'/listmovies')
  }
  getMovie(id:number):Observable<IMovie>
  {
      return this.httpclient.get<IMovie>(this.url+'/listmovies/'+id)
  }
  httpOptions={headers:new HttpHeaders({'Content-type':'application/json'})}
  addMovie(moviedata:IMovie):Observable<IMovie>{
    return this.httpclient.post<IMovie>(this.url+'/AddMovie',moviedata,this.httpOptions)
  }
  editMovie(moviedata:IMovie):Observable<IMovie>
  {
    return this.httpclient.put<IMovie>(this.url+'/EditMovie/'+ moviedata.id,moviedata,this.httpOptions)
  }
  deleteMovie(id:number):Observable<IMovie>
  {
    return this.httpclient.delete<IMovie>(this.url+'/DeleteMovie/'+id)
  }
}