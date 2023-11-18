import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, NgForm } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ListmovieComponent } from './listmovie/listmovie.component';
import { FindmovieComponent } from './findmovie/findmovie.component';
import { MenuComponent } from './menu/menu.component';
import { HttpClientModule } from '@angular/common/http';
import { AddMovieComponent } from './add-movie/add-movie.component';
import { EditmovieComponent } from './editmovie/editmovie.component';
import { DeletemovieComponent } from './deletemovie/deletemovie.component';
import { ReactFormComponent } from './react-form/react-form.component';
import { ReactiveFormsModule } from '@angular/forms';
import { CreatedetailsComponent } from './createdetails/createdetails.component';

@NgModule({
  declarations: [
    AppComponent,
    ListmovieComponent,
    FindmovieComponent,
    MenuComponent,
    AddMovieComponent,
    EditmovieComponent,
    DeletemovieComponent,
    ReactFormComponent,
    CreatedetailsComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
