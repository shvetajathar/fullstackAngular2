import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { IMovie } from '../model/imovie';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class MovieService {
  private url='beaddfcabfedbecfabcaaaceeafebeccaddbefddaf.premiumproject.examly.io/Movie)'
  private url2='beaddfcabfedbecfabcaaaceeafebeccaddbefddaf.premiumproject.examly.io/Detail'

  constructor(private httpclient:HttpClient) { }
  getAllMovies():Observable<any[]>
  {
    return this.httpclient.get<any[]>(this.url+'/listmovies')
  }
}
