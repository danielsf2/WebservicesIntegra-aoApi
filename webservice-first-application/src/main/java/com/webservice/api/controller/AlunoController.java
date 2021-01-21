package com.webservice.api.controller;

import com.webservice.api.models.Aluno;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RestController;
import com.webservice.api.repository.AlunoRepository;

@RestController
public class AlunoController {

    @Autowired
    AlunoRepository alunoRepository;

    @PostMapping(name = "/api/aluno/salvar")
    public Aluno salvarAluno(@RequestBody Aluno aluno){return alunoRepository.save(aluno);}

}//class AlunoController
