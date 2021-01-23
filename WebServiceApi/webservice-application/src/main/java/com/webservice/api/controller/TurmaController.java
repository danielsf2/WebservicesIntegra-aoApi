package com.webservice.api.controller;

import com.webservice.api.models.Turma;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;
import com.webservice.api.repository.TurmaRepository;

@RestController
public class TurmaController {

    @Autowired
    TurmaRepository turmaRepository;

    @GetMapping(path = "/api/turma/{codigo}")
    public ResponseEntity<Turma> consultarId(@PathVariable("codigo") Integer codigo){

        return turmaRepository.findById(codigo).map(record -> ResponseEntity.ok().body(record)).
                orElse(ResponseEntity.notFound().build());
    }

    @PostMapping(path = "/api/turma/excluir/{codigo}")
    public void excluir (@PathVariable ("codigo") Integer turmaId){
        turmaRepository.deleteById(turmaId);
    }

    @GetMapping(path = "/api/turma/listar")
    public Iterable<Turma> listarTurmas(){

        return turmaRepository.findAll();
    }

    @PostMapping(path = "/api/turma/salvar")
    public Turma salvarTurma (@RequestBody Turma turma){ return turmaRepository.save(turma);}

}//class TurmaController
