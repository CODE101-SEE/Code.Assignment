import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { AppSettings } from 'src/AppSettings';
import { IJedi } from './ijedi';
@Component({
  selector: 'app-jedi-list',
  templateUrl: './jedi-list.component.html',
  styleUrls: ['./jedi-list.component.scss']
})
export class JediListComponent implements OnInit {

  public jediList: IJedi[] = [];
  public isLoading = false;

  constructor(
    private http: HttpClient,
  ) { }

  public ngOnInit(): void {
    console.log("I'm fired up");
    this.refresh();
  }

  public refresh() {
    if (this.isLoading) { return; }

    this.isLoading = true;

    setTimeout(() => {
      this.http.get(AppSettings.API_BASE_URL + 'jedi').subscribe((res) => {
        this.jediList = (res as any).$values;
        this.isLoading = false;
      });
    }, 500);
  }

}
