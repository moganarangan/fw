import { Component, AfterViewInit } from '@angular/core';
import { FwService } from '../fw.service';

@Component({
  selector: 'app-left-panel',
  templateUrl: './left-panel.component.html',
  styleUrls: ['./left-panel.component.scss']
})
export class LeftPanelComponent implements AfterViewInit {

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
