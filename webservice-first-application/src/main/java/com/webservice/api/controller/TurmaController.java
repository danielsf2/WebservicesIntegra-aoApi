package com.webservice.api.controller;

import com.webservice.api.models.Turma;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;
import com.webservice.api.repository.TurmaRepository;

@RestController
public class TurmaController {

    @Autowired
    TurmaRepository turmaRepository;

    @GetMapping(path = "/api/turma/{codigo}")
    public void consultar(@PathVariable("codigo") Integer codigo){

        turmaRepository.deleteAll();
        //return turmaRepository.findAll();//.map(record -> ResponseEntity.ok().body(record)).
                //orElse(ResponseEntity.notFound().build());
    }

    @PostMapping(path = "/api/turma/salvar")
    public Turma salvarTurma (@RequestBody Turma turma){ return turmaRepository.save(turma);}

}//class TurmaController
