import { Injectable } from '@angular/core';
import { Observable, Subject } from 'rxjs';
import { Message, MessageService } from 'primeng/api';

@Injectable({ providedIn: 'root' })
export class AlertHelper {
    private subject = new Subject<any>();

    constructor(private primeNgMsgService: MessageService) {}

    getAlert(): Observable<any> {
        return this.subject.asObservable();
    }

    success(message: string, detail?: string) {
        // this.toastr.success(message);
        const _message:Message = this.createMessage(message, detail);
        _message.severity = 'success';
        this.primeNgMsgService.add(_message);
    }

    error(message: string, detail?: string) {
        // this.toastr.error(message );
        const _message:Message = this.createMessage(message, detail);
        _message.severity = 'error';
        this.primeNgMsgService.add(_message);
    }

    info(message: string, detail?: string) {
        const _message:Message = this.createMessage(message, detail);
        _message.severity = 'info';
        this.primeNgMsgService.add(_message);
    }

    warm(message: string, detail?: string) {
        const _message:Message = this.createMessage(message, detail);
        _message.severity = 'warm';
        this.primeNgMsgService.add(_message);
    }

    createMessage(summary: string, severity?:string, detail?: string) {
        const _message: Message = {
            summary: summary,
        }
        if(typeof severity != "undefined") _message.severity = severity;
        if(typeof detail != "undefined") _message.detail = detail;
        return _message;
    }

    printMsg(message:Message){ this.primeNgMsgService.add(message);}
    printMultiMsg(message:Message[]){ this.primeNgMsgService.addAll(message);}
    getMsgService(){ return this.primeNgMsgService; }

    clear() {
        // clear by calling subject.next() without parameters
        // this.subject.next(null);
        this.primeNgMsgService.clear();
    }
}