import { Component, OnInit } from '@angular/core';
import { IMovie } from '../model/imovie';
import { MovieService } from '../movieservice/movie.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-addmovie',
  templateUrl: './addmovie.component.html',
  styleUrls: ['./addmovie.component.css']
})
export class AddmovieComponent implements OnInit {
  moviedata:IMovie={id:0,name:'',yearRelease:0,rating:0}

  constructor(private ms:MovieService,private route:Router) { }
  saveData(movie:IMovie):void{
    this.moviedata=movie
    this.ms.addMovie(this.moviedata).subscribe(
      ()=>{
        alert('Record Added Successfully.')
        this.route.navigate(['/listmovies'])
      }
    )

  }

  ngOnInit() {
  }

}
