import { Component, AfterViewInit } from '@angular/core';
import { FwService } from '../fw.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements AfterViewInit {

  public files: any;

  constructor(private fwService: FwService) { }

  ngAfterViewInit() {
    this.getFiles();
  }

  getFiles = () => {
    this.fwService.getfiles().subscribe(
      data => this.files = data,
      error => console.log(error)
    );
  }

}
