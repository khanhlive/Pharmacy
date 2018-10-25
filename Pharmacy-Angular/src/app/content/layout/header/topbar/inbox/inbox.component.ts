import { Component,
	OnInit,
	HostBinding,
	HostListener,
	Input,
	ChangeDetectionStrategy } from '@angular/core';

@Component({
  selector: 'm-inbox',
  templateUrl: './inbox.component.html',
  changeDetection: ChangeDetectionStrategy.OnPush
})
export class InboxComponent implements OnInit {
  @HostBinding('class')
  classes = 'dropdown dropdown-extended dropdown-inbox';
  constructor() { }

  ngOnInit() {
  }

}
